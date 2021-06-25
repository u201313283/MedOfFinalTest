Feature: VisualizarHorario
	Como doctor 
	necesito poder ver todas las citas programadas del día o semana 
	para organizar mi tiempo y próximas citas.

@mytag
Scenario: Visualización de Horario Exitoso
	Given la acción de login correcto
	When el usuario sea redireccionado a la vista de citas
	Then el sistema verificará que el usuario tenga citas programadas y no hayan sido canceladas, mostrará un calendario con las citas en formato día/semana/mes

	
@mytag
Scenario: Visualización de Horario Erroneo
	Given la acción de login correcto
	When el usuario sea redireccionado a la vista de citas
	Then el sistema detectará que el usuario no tiene citas programadas y mostrará un mensaje indicando que no tiene citas programadas

	
@mytag
Scenario: Visualización de Horario Erroneo Dos
	Given la acción de login correcto
	When el usuario sea redireccionado a la vista de citas
	Then el sistema detectará que el usuario no tiene citas programadas en la semana actual y mostrará un mensaje indicando que tiene citas programadas la semana siguiente