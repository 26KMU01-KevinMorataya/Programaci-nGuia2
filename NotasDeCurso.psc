Algoritmo NotasDeCurso
	Definir Notas Como Caracter
	
	Escribir "************************"
	Escribir "*   Notas   *"
	Escribir "************************"
	
	Escribir "A = Excelente."
	Escribir "B = Bueno."
	Escribir "C = Regular."
	Escribir "D = Deficiente."
	Escribir "F = Reprobado."
	
	
	Escribir Sin Saltar "Digite la opcion [] :"
	Leer Notas
	
	Segun Notas Hacer
		"A":
			Escribir "Escelente"
		"B":
			Escribir "Bueno"
		"C":
			Escribir "Regular"
		"D":
			Escribir "Deficiente"
		"F":
			Escribir "Reprobado"
		De Otro Modo:
			Escribir "Error al operar las notas"
	FinSegun
	
	
FinAlgoritmo
