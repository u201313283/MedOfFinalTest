Feature: AgregarReceta
	Como doctor 
	necesito poder agregar una receta de mi paciente en cada cita 
	para mantener actualizado su historial clínico.

	Background: Login exitoso
		Given Login exitoso
@mytag
Scenario: Receta Agregada Correctamente
	Given una petición de registro de una receta para una cita 
	And teniendo los campos del formulario llenados correctamente
	When el usuario haga click en el botón CREAR RECETA
	Then el sistema ingresará la información de la nueva receta en la base de datos 


@mytag
Scenario: Receta No Agregada
	Given una petición de registro de una receta para una cita 
	And teniendo los campos del formulario llenados incorrectamente
	When el usuario haga click en el botón CREAR RECETA
	Then el sistema indicará al usuario que datos fueron incorrectos


@mytag
Scenario: Receta No Agregada Dos
	Given una petición de registro de una receta para una cita 
	And teniendo los campos del formulario vacíos
	When el usuario haga click en el botón CREAR RECETA
	Then el sistema indicará al usuario que los campos no fueron llenados