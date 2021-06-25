Feature: ModificarDiagnostico
	Como doctor 
	necesito poder editar un diagnóstico de mi paciente 
	para mantener actualizado su historial clínico.

@mytag
Scenario: Diagnostico Modificado Exitosamente
	Given una petición de edición de los datos de un diagnóstico
	When el usuario de click en la cita a la que pertenece el diagnostico
	Then el sistema verificará que la cita haya finalizado y llenará un formulario modificable con los datos del diagnóstico y detectará que fueron modificados con datos correctos, acto seguido los modificará en la base de datos
	

@mytag
Scenario: Diagnostico Modificado Erroneamente
	Given una petición de edición de los datos de un diagnóstico
	When el usuario de click en la cita a la que pertenece el diagnostico
	Then el sistema verificará que la cita haya finalizado y llenará un formulario modificable con los datos del diagnóstico y detectará que fueron modificados con datos incorrectos, acto seguido notificará al usuario que campos están erróneos
	

@mytag
Scenario: Diagnostico Modificado Erroneamente Dos
	Given una petición de edición de los datos de un diagnóstico
	When el usuario de click en la cita a la que pertenece el diagnostico
	Then el sistema detectará que la cita no ha empezado e indicará al usuario que necesita empezar la cita para poder crear un diagnóstico