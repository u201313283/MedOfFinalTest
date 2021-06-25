Feature: EditarPaciente
	Como doctor 
	necesito poder descargar mi agenda de citas diarias y semanales para visualizarlas aún sin internet.

@mytag
Scenario: Editar Paciente Exitoso
	Given una petición de edición de los datos de un paciente
	When el usuario de click en el botón EDITAR
	Then el sistema llenará un formulario modificable con los datos del paciente y validará que los datos hayan sido modificados y estén completados correctamente y serán ingresados a la base de datos


@mytag
Scenario: Editar Paciente Erroneo
	Given una petición de edición de los datos de un paciente
	When el usuario de click en el botón EDITAR
	Then el sistema llenará un formulario modificable con los datos del paciente y detectará que un campo ha sido modificado incorrectamente, indicará al usuario que campo fue escrito incorrectamente


@mytag
Scenario: Editar Paciente Erroneo Dos
	Given una petición de edición de los datos de un paciente
	When el usuario de click en el botón EDITAR
	Then el sistema llenará un formulario modificable con los datos del paciente y detectará que uno o más campos están en blanco, mostrará un mensaje en pantalla indicando que uno o más campos no fueron llenados.
