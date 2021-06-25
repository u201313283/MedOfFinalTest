Feature: Registrar Cita
	Como doctor 
	necesito poder agregar una nueva cita 
	para visualizarla en mi agenda de citas.

	Background: Login exitoso
		Given Login exitoso
@mytag
Scenario: Registro de Cita Exitoso
	Given una petición de registro de una nueva cita 
	And los campos del formulario fueron llenados de forma incorrecta
	When el usuario haga click en el botón CREAR CITA
	Then el sistema ingresará la información de la nueva cita a la base de datos


@mytag
Scenario: Registro de Cita Erroneo
	Given una petición de registro de una  cita
	And los campos del formulario fueron llenados incorrectamente
	When el usuario de click en el botón CREAR CITA
	Then el sistema no ingresará la información de la nueva cita a la base de datos, y mostrará al usuario los campos incorrectos


@mytag
Scenario: Registro de Cita Erroneo Dos
	Given una petición de registro de cita 
	And los campos del formulario no fueron llenados
	When el usuario clickee en el botón CREAR CITA
	Then el sistema mostrará un mensaje en pantalla indicando que uno o más campos no fueron llenados