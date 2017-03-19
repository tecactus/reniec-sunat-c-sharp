# RENIEC-SUNAT-C#
   
## Instalación

Instalar usando [NuGet](https://www.nuget.org/packages/Tecactus.Api):

```bash
   PM> Install-Package Tecactus.Api
```

O agregar los siguientes dll a tu proyecto:

- [RestSharp.dll](https://github.com/tecactus/reniec-sunat-c-sharp/releases/download/1.2.0/RestSharp.dll)
- [Tecactus.dll](https://github.com/tecactus/reniec-sunat-c-sharp/releases/download/1.2.0/Tecactus.dll)

## Uso

### Para consultar DNI

```csharp
	try
	{
		// instanciar un objecto de la clase Dni
		var dni = new Tecactus.Api.Reniec.Dni("tu-token-de-acceso-personal");

		// el método 'get' devuelve un objeto de la clase Person.
		// Caso contrario lanza una excepción cuyo mensaje describe el error sucitado.
		var Tecactus.Api.Reniec.Person person = dni.get("12345678");
	}
	catch (Exception exception)
	{
		MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
	}
```

### Para consultar RUC

```csharp
	try
	{
		// instanciar un objecto de la clase Ruc
		var ruc = new Tecactus.Api.Sunat.Ruc("tu-token-de-acceso-personal");

		// el método 'get' devuelve un objeto de la clase Company.
		// Caso contrario lanza una excepción cuyo mensaje describe el error sucitado.
		var Tecactus.Api.Sunat.Company company = ruc.get("12345678901");
	}
	catch (Exception exception)
	{
		MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
	}
```

## Lista de Excepciones

### Tecactus.Api.Exception.**CanceledByDeathException**
El DNI consultado fue cancelado por fallecimiento y no puede ser consultado.
Resultado correcto de consulta.
Response 200 OK, cuenta como consulta válida.

### Tecactus.Api.Exception.**DniNotFoundException**
El DNI consultado no fue encontrado.
Resultado correcto de consulta.
Response 200 OK, cuenta como consulta válida.

### Tecactus.Api.Exception.**DniUnderageException**
El DNI consultado pertenece a un menor de edad y no puede ser consultado.
Resultado correcto de consulta.
Response 200 OK, cuenta como consulta válida.

### Tecactus.Api.Exception.**InternalServerErrorException**
Error interno del servidor.
Consulta no ejecutada.
Response 500 Internal Server Error, no cuenta como consulta.

### Tecactus.Api.Exception.**InvalidDniException**
El DNI consultado no es válido.
Resultado correcto de consulta.
Response 200 OK, cuenta como consulta válida.

### Tecactus.Api.Exception.**RucNotFoundException**
El RUC consultado no fue encontrado.
Resultado correcto de consulta.
Response 200 OK, cuenta como consulta válida.

### Tecactus.Api.Exception.**InvalidRucException**
El RUC consultado no es válido.
Resultado correcto de consulta.
Response 200 OK, cuenta como consulta válida.

### Tecactus.Api.Exception.**PageNotFoundException**
Ruta del API consultado no existe.
Consulta no ejecutada.
Response 404 Page Not Found, no cuenta como consulta.

### Tecactus.Api.Exception.**TooManyRequestException**
Demasiadas solicitudes. Se ha superado la cuota establecida.
Consulta no ejecutada.
Response 429 Too Many Requests, no cuenta como consulta.

### Tecactus.Api.Exception.**TryAgainInSecondsException**
La consulta no pudo ser procesada, servicio no disponible, intente nuevamente en unos segundos.
Consulta no ejecutada.
Response 503 Service Unavailable, no cuenta como consulta.

### Tecactus.Api.Exception.**UnauthenticatedException**
Sin autorización. La consulta no tiene un token válido.
Resultado correcto de consulta.
Response 401 Unauthorized, cuenta como consulta válida.

## Token de Acceso Personal

Para crear tokens de acceso personal debes de iniciar sesión en Tecactus:

[https://tecactus.com/auth/login](https://tecactus.com/auth/login)

Si no estas registrado aún, puedes hacerlo en:

[https://tecactus.com/auth/register](https://tecactus.com/auth/register)

Debes de activar tu cuenta si aún no lo has hecho.
Luego ver el panel de gestión de Tokens de acceso en:

[https://tecactus.com/developers/configuracion/tokens](https://tecactus.com/developers/configuracion/tokens)