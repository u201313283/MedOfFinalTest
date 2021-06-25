Feature: AgregarDiagnostico
	Como doctor 
	necesito poder agregar un diagnóstico de mi paciente en cada cita 
	para mantener actualizado su historial clínico.

	Background: Login exitoso
		Given Login exitoso
@mytag
Scenario: Diagnostico Agregado Correctamente
	Given una petición de registro de un diagnostico para una cita 
	And teniendo los campos del formulario llenados correctamentes
	When el usuario haga click en el botón CREAR DIAGNOSTICO
	Then el sistema ingresará la información del nuevo diagnostico en la base de datos. 

	
@mytag
Scenario: Diagnostico Agregado Incorrectamente
	Given una petición de registro de un diagnostico para una cita
	And teniendo los campos del formulario llenados incorrectamente
	When el usuario haga click en el botón CREAR DIAGNOSTICO
	Then el sistema indicará al usuario que datos fueron incorrectos



@mytag
Scenario: Diagnostico Agregado Incorrectamente Dos
	Given una petición de registro de un diagnostico para una cita 
	And teniendo los campos del formulario vacíos
	When el usuario haga click en el botón CREAR DIAGNOSTICO
	Then el sistema indicará al usuario que los campos no fueron llenados

