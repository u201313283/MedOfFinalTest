Feature: EliminarCita
	Como doctor 
	necesito poder eliminar una cita 
	para que deje de mostrarse en mi agenda de citas.

@mytag
Scenario: Eliminación de Cita Exitoso
	Given una petición de la eliminación de una cita
	When cuando el usuario haga click en el botón ELIMINAR CITA
	Then el sistema verificará que la cita se haya realizado y procederá a eliminar la cita de forma lógica


@mytag
Scenario: Eliminación de Cita Erronea
	Given una petición de la eliminación de una cita
	When cuando el usuario haga click en el botón ELIMINAR CITA
	Then el sistema verificará que la cita no se haya realizado aún y procederá a eliminar la cita de forma física
	

@mytag
Scenario: Eliminación de Cita Erronea Dos
	Given una petición de la eliminación de una cita
	When cuando el usuario haga click en el botón ELIMINAR CITA
	Then sistema detectará que la cita está siendo realizada y mostrará un mensaje al usuario indicando que debe de terminar la cita para poder realizar la acción