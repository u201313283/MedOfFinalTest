Feature: RegistrarUsuario
	Como doctor 
	necesito poder registrarme en la plataforma 
	para poder hacer uso de la aplicación.

@mytag
Scenario: Registro de Usuario Exitoso
	Given una petición de registro en la plataforma 
	And los cambos del formulario fueron llenados correctamente
	When cuando el usuario haga click en el botón REGISTRAR
	Then el sistema ingresará la información del nuevo usuario en la base de datos


@mytag
Scenario: Registro de Usuario Erroneo
	Given una petición de registro en la plataforma 
	And los campos del formulario fueron llenados incorrectamente
	When cuando el usuario haga click en el botón REGISTRAR
	Then el sistema no ingresará la información del nuevo usuario en la base de datos, y mostrará al usuario los campos incorrectos


@mytag
Scenario: Registro de Usuario Erroneo Dos
	Given una petición de registro en la plataforma 
	And los campos del formulario no fueron llenados
	When cuando el usuario haga click en el botón REGISTRAR
	Then el sistema mostrará un mensaje en pantalla indicando que uno o más campos no fueron llenados