Feature: NotificarPaciente
	Como doctor 
	necesito que la aplicación notifique mi paciente un día antes de su cita 
	para recordársela.

	Background: Login exitoso
		Given Login exitoso
@mytag
Scenario: Notificación al Paciente Exitosa
	Given la petición de notificarle al paciente su cita programada
	When el usuario de click en el botón NOTIFICAR
	Then el sistema validará que la cita no haya empezado y enviará un correo al paciente indicando la fecha y hora de su cita, notificando al médico que el correo fue enviado con éxito

	
@mytag
Scenario: Notificación al Paciente Erronea
	Given la petición de notificarle al paciente su cita programada
	When el usuario de click en el botón NOTIFICAR
	Then el sistema validará que la cita no haya empezado y enviará un correo al paciente indicando la fecha y hora de su cita, notificando al médico que el correo del paciente no existe.

	
@mytag
Scenario: Notificación al Paciente Erronea Dos
	Given la petición de notificarle al paciente su cita programada
	When el usuario de click en el botón NOTIFICAR
	Then el sistema detectará que la cita ya finalizó, notificando al médico que la cita ya ha concluido y no se puede notificar.