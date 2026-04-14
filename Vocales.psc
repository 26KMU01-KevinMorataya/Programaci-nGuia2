Algoritmo Vocales
	Definir d Como Caracter
	
	Escribir "Ingrese un caracter: "
	Leer d
	
	Si d = "a" o d = "e" o d = "i" o d = "o" o d = "u" o d = "A" o d = "E" o d = "I" o d = "O" o d = "U" Entonces
		Escribir "Es una vocal"
		
	SiNo
		Si d >= "0" Y d <= "9" Entonces
			Escribir "Es un numero"
		SiNo
			Escribir "No es vocal, ni numero"
		FinSi
	FinSi
FinAlgoritmo