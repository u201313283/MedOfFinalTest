Feature: ModificarReceta
	Como doctor 
	necesito poder editar una receta de mi paciente 
	para mantener actualizado su historial clínico.

@mytag
Scenario: Modificación de Receta Correcta
	Given una petición de edición de los datos de una receta
	When cuando el usuario de click en la cita a la que pertenece la receta
	Then el sistema verificará que la cita haya finalizado y llenará un formulario modificable con los datos de la receta y detectará que fueron modificados con datos correctos, acto seguido los modificará en la base de datos

	
@mytag
Scenario: Modificación de Receta Incorrecta
	Given una petición de edición de los datos de una receta
	When cuando el usuario de click en la cita a la que pertenece la receta
	Then el sistema verificará que la cita haya finalizado y llenará un formulario modificable con los datos de la receta y detectará que fueron modificados con datos incorrectos, acto seguido notificará al usuario que campos están erróneos


	
@mytag
Scenario: Modificación de Receta Incorrecta Dos
	Given una petición de edición de los datos de una receta
	When cuando el usuario de click en la cita a la que pertenece la receta
	Then el sistema detectará que la cita no ha empezado e indicará al usuario que necesita empezar la cita para poder crear una receta