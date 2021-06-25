Feature: EditarCita
	Como doctor 
	necesito poder modificar la fecha, hora y motivo de una cita 
	para que se actualice en mi agenda de citas.

@mytag
Scenario: Edición de Cita Exitoso
	Given una petición de edición de una cita programada
	When el usuario de click en el botón EDITAR CITA
	Then el sistema validará que la cita aún no se haya dado y mostrará un formulario con lleno con los datos modificables de la cita para su edición


@mytag
Scenario: Edición de Cita Erroneo
	Given una petición de edición  una cita programada
	When el usuario haga click en el botón EDITAR CITA
	Then el sistema detectará que la cita ya fue hecha y mostrará un mensaje al usuario donde indica que no puede ser modificada.


@mytag
Scenario: Edición de Cita Erroneo Dos
	Given una petición de editar una cita programada
	When el usuario clickee en el botón EDITAR CITA
	Then el sistema detectará que la cita está siendo realizada y mostrará un mensaje al usuario donde indica que no puede ser modificada.
