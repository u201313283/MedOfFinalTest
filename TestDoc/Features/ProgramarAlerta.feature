Feature: ProgramarAlerta
	Como doctor 
	necesito que la aplicación me notifique de la siguiente cita programada 
	para estar listo para atenderla.

@mytag
Scenario: Programación de Alerta Exitosa
	Given la petición de notificarle al médico su cita programada
	When cuando el usuario de click en el botón NOTIFICAR
	Then el sistema validará que la cita no haya empezado y enviará un correo al paciente indicando la fecha y hora de su cita, notificando al médico que el correo fue enviado con éxito


@mytag
Scenario: Programación de Alerta Erronea
	Given la petición de notificarle al médico su cita programada
	When cuando el usuario de click en el botón NOTIFICAR
	Then el sistema validará que la cita no haya empezado y enviará un correo al paciente indicando la fecha y hora de su cita, notificando al médico que el correo del paciente no existe.

	
@mytag
Scenario: Programación de Alerta Erronea Dos
	Given la petición de notificarle al médico su cita programada
	When cuando el usuario de click en el botón NOTIFICAR
	Then el sistema detectará que la cita ya finalizó, notificando al médico que la cita ya ha concluido y no se puede notificar.