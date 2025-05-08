# fis-client-csharp
<p>FIS Financial Inclusion Score, desarrollado por Círculo de Crédito, permite evaluar a personas sin historial crediticio. Su propósito es promover la inclusión financiera al calificar al 100% de esta población.<br/><img src='https://developer.circulodecredito.com.mx/sites/default/files/2020-11/circulo_de_credito-apihub_0.png'  width='200'/></p><br/>

## Requisitos para Windows

- .NET Core 3.1 SDK [vea como instalar][1]
- MonoDevelop [vea como instalar][2]
- Microsoft .NET Framework 4.5 Developer Pack [vea como instalar][3]

### Requisitos para linux/MacOs
- Se debe contar con las siguientes dependencias para SO linux:
    - nuget
    - mono-devel
    - mono-xbuild
    - wget

```sh
#ejemplo para instalar las dependencias adicionales
apt install nuget
apt install mono-devel
apt install mono-xbuild
apt install wget
```


## Guía de inicio

### Paso 1. Generar llave y certificado

- Se tiene que tener un contenedor en formato PKCS12.
- En caso de no contar con uno, ejecutar las instrucciones contenidas en **lib/Interceptor/createKeystore.sh** ó con los siguientes comandos.
- **opcional**: Para cifrar el contenedor, colocar una contraseña en una variable de ambiente.
```sh
export KEY_PASSWORD=your_password
```
- Definir los nombres de archivos y alias.
```sh
export PRIVATE_KEY_FILE=pri_key.pem
export CERTIFICATE_FILE=certificate.pem
export SUBJECT=/C=MX/ST=MX/L=MX/O=CDC/CN=CDC
export PKCS12_FILE=keypair.p12
export ALIAS=circulo_de_credito
```
- Generar llave y certificado.
```sh
#Genera la llave privada.
openssl ecparam -name secp384r1 -genkey -out ${PRIVATE_KEY_FILE}
#Genera el certificado público.
openssl req -new -x509 -days 365 \
    -key ${PRIVATE_KEY_FILE} \
    -out ${CERTIFICATE_FILE} \
    -subj "${SUBJECT}"
```
- Generar contenedor en formato PKCS12.
```sh
# Genera el archivo pkcs12 a partir de la llave privada y el certificado.
# Deberá empaquetar la llave privada y el certificado.
openssl pkcs12 -name ${ALIAS} \
    -export -out ${PKCS12_FILE} \
    -inkey ${PRIVATE_KEY_FILE} \
    -in ${CERTIFICATE_FILE} -password pass:${KEY_PASSWORD}
```

### Paso 2. Cargar el certificado dentro del portal de desarrolladores

 1. Iniciar sesión.
 2. Dar clic en la sección "**Mis aplicaciones**".
 3. Seleccionar la aplicación.
 4. Ir a la pestaña de "**Certificados para @tuApp**".
    <p align="center">
      <img src="https://github.com/APIHub-CdC/imagenes-cdc/blob/master/applications.png">
    </p>
 5. Al abrirse la ventana emergente, seleccionar el certificado previamente creado y dar clic en el botón "**Cargar**":
    <p align="center">
      <img src="https://github.com/APIHub-CdC/imagenes-cdc/blob/master/upload_cert.png" width="268">
    </p>

### Paso 3. Descargar el certificado de Círculo de Crédito dentro del portal de desarrolladores

 1. Iniciar sesión.
 2. Dar clic en la sección "**Mis aplicaciones**".
 3. Seleccionar la aplicación.
 4. Ir a la pestaña de "**Certificados para @tuApp**".
    <p align="center">
        <img src="https://github.com/APIHub-CdC/imagenes-cdc/blob/master/applications.png">
    </p>
 5. Al abrirse la ventana emergente, dar clic al botón "**Descargar**":
    <p align="center">
        <img src="https://github.com/APIHub-CdC/imagenes-cdc/blob/master/download_cert.png" width="268">
    </p>

### Paso 4. Agregar el producto a la aplicación

Al iniciar sesión seguir os siguientes pasos:

 1. Dar clic en la sección "**Mis aplicaciones**".
 2. Seleccionar la aplicación.
 3. Ir a la pestaña de "**Editar '@tuApp**' ".
    <p align="center">
      <img src="https://github.com/APIHub-CdC/imagenes-cdc/blob/master/edit_applications.jpg" width="900">
    </p>
 4. Al abrirse la ventana emergente, seleccionar el producto.
 5. Dar clic en el botón "**Guardar App**":
    <p align="center">
      <img src="https://github.com/APIHub-CdC/imagenes-cdc/blob/master/selected_product.jpg" width="400">
    </p>

### Paso 5. Configuración de verificación y firmado de paloads

Es importante editar el archivo llamado Config.xml que se encuentra en la **/path/to/repository/src/IO.Fis/Interceptor/Config.xml** dónde encontrará algo como lo siguiente.
```xml
    <?xml version="1.0" encoding="utf-8" standalone="no"?>
    <configuration>
        <keypairPath>your_path_for_your_keystore</keypairPath>
        <keypairPassword>your_super_secure_keystore_password</keypairPassword>
        <certificatePath>your_path_for_certificate_of_cdc</certificatePath>
    </configuration>
```

### Paso 6. Capturar los datos de la petición

Los siguientes datos a modificar se encuentran en ***IO.Fis.Test/Api/Fis.cs***

Es importante contar con el método Init() que se encargará de inicializar la url. Modificar la URL ***('the_url')*** de la petición de la variable ***basePath***, como se muestra en el siguiente fragmento de código:

```csharp

[SetUp]
public void Init()
{
    string basePath = "the_url/v1-1/fis/persona";
    this.xApiKey = "your_api_key";
    this.username = "your_username";
    this.password = "your_passwords";
    this.apiTest = new FisApi(basePath);
}

/**
* Este es el método que se será ejecutado en la prueba unitaria, ubicado en path/to/repository/src/IO.Fis.Test/Api/Fis.cs 

*/
[Test]
    public void GetScoreTest()
    {

        PersonaPeticion request = new PersonaPeticion();
        DomicilioPeticion domicilio = new DomicilioPeticion();
        
        request.PrimerNombre ="LLLLLLLL";
        request.ApellidoPaterno ="LLLLLLLL";
        request.ApellidoMaterno ="LLLLLLLL";
        request.FechaNacimiento ="NN-NN-NNNN";
        request.Nacionalidad = CatalogoNacionalidad.MX;
        request.RFC ="LLLLNNNNNN";
        request.CURP ="LLLLLLLLLLLLLLLLLL";

        domicilio.Direccion = "LLLLLLLL LL";
        domicilio.ColoniaPoblacion = "LLLLLLLL";
        domicilio.Ciudad = "LLLLLLLL";
        domicilio.Estado = CatalogoEstados.DF;
        domicilio.DelegacionMunicipio = "LLLLLLLL";
        domicilio.CP = "NNNNN";
        domicilio.NumeroTelefono = "5555555555";

        request.Domicilio = domicilio;

        var response = this.apiTest.GetFis(this.xApiKey, this.username, this.password, request);
        Assert.IsInstanceOf<Respuesta> (response, "response is Respuesta");
        Console.WriteLine(response);
    }
```
## Pruebas unitarias

Para ejecutar las pruebas unitarias con windows:
```sh
# Compilación
build.bat
dotnet msbuild IO.Fis.sln
# Ejecución
"packages/NUnit.Runners.2.6.4/tools/nunit-console.exe" src/IO.Fis.Test/bin/Debug/IO.Fis.Test.dll

```

Para ejecutar las pruebas unitarias con linux:

```sh
# Compilación
sh build.sh
# Ejecución
sh mono_nunit_test.sh
# También puede probar con el siguiente comando
msbuild IO.Fis.sln && \
    mono .bin/IO.Fis.Test/bin/Debug/IO.Fis.Test.dll

```
---
[CONDICIONES DE USO, REPRODUCCIÓN Y DISTRIBUCIÓN](https://github.com/APIHub-CdC/licencias-cdc)

[1]: https://dotnet.microsoft.com/download
[2]: https://www.mono-project.com/download/stable/#download-win
[3]: https://www.microsoft.com/es-mx/download/details.aspx?id=30653