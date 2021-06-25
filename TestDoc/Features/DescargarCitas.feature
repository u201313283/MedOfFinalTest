Feature: DescargarCitas
	Como doctor 
	necesito poder descargar mi agenda de citas diarias y semanales 
	para visualizarlas aún sin internet.

@mytag
Scenario: Descarga de Citas Exitosa
	Given una petición de descarga del cronograma diario de citas
	When el usuario de click en el botón DESCARGAR
	Then el sistema verificará que tenga citas programadas y escribirá un archivo descargable con las citas diarias 


@mytag
Scenario: Descarga de Citas Erronea
	Given una petición de descarga del cronograma diario de citas
	When el usuario de click en el botón DESCARGAR
	Then el sistema detectará que no tiene citas programadas y mostrará un mensaje al usuario indicando que no tiene citas en los siguientes días


@mytag
Scenario: Descarga de Citas Erronea Dos
	Given una petición de descarga del cronograma diario de citas
	When el usuario de click en el botón DESCARGAR
	Then el sistema detectará que no tiene citas en el día pero si para la semana y creará una ventana de confirmación para descargar las citas