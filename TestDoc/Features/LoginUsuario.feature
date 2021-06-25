Feature: LoginUsuario
	Como doctor
	necesito poder ingresar a la aplicación con un usuario y contraseña 
	para mantener mi información privada.

@mytag
Scenario: Login Exitoso
	Given un intento de logueo con correo y contraseña válidos
	When el usuario dé click en el botón ENTRAR
	Then el sistema lo redireccionará a su vista de citas


@mytag
Scenario: Login Erroneo
	Given un intento de logueo con correo y contraseña inválidos
	When el usuario haga click en el botón ENTRAR
	Then el sistema notificará que el correo/contraseña son incorrectos


@mytag
Scenario: Login Erroneo Dos
	Given 3 intentos seguidos de logueo con correo y contraseña inválidos
	When el usuario  clickee en el botón ENTRAR
	Then el sistema bloqueará la cuenta por 15 minutos