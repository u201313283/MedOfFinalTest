Feature: RegistrarPaciente
	Como doctor 
	necesito poder agregar a un paciente 
	para mantener un registro de mis pacientes.

	Background: Login exitoso
		Given Login exitoso
@mytag
Scenario: Registro de Paciente Exitoso
	Given una petición de registro de paciente 
	And los campos del formulario fueron llenados correctamente
	When el usuario haga click en el botón REGISTRAR
	Then el sistema ingresará la información del nuevo paciente en la base de datos 


@mytag
Scenario: Registro de Paciente Erroneo
	Given una petición de registro de paciente 
	And los campos del formulario fueron llenados incorrectamente
	When el usuario haga click en el botón REGISTRAR
	Then el sistema no ingresará la información del nuevo paciente en la base de datos, y mostrará al usuario los campos incorrectos


@mytag
Scenario: Registro de Paciente Erroneo Dos
	Given una petición de registro de paciente 
	And los campos del formulario no fueron llenados
	When el usuario haga click en el botón REGISTRAR
	Then el sistema mostrará un mensaje en pantalla indicando que uno o más campos no fueron llenados 