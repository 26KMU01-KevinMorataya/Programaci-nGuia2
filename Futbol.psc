Algoritmo Estadio
	Definir s, e Como Entero
	Definir precio Como Real
	Escribir "1. Palco (Q300)"
	Escribir "2. Tribuna (Q100 - Q125)"
	Escribir "3. Preferencia (Q50 - Q75)"
	Escribir "4. Generales (Q30 - Q50)"
	Escribir "Seleccione su lugar: "
	leer s
	Escribir "¿Cuantas entradas?: "
	leer e 
	Segun s Hacer
		1:
			p <- 300
			Escribir "Lugar - Palco"
			Escribir "Precio: Q", precio * e
			
		2:
			Escribir "Ingrese el precio: "
			Leer p
			Si p >= 100 Y p <= 125 Entonces
				Escribir "Lugar - Tribuna"
				Escribir "Precio: Q", precio * e 
			SiNo
				Escribir "Precio no aceptado"
			FinSi
			
		3:
			Escribir "Ingrese el precio : "
			Leer p
			Si p >= 50 Y p <= 75 Entonces
				Escribir "Lugar - Preferencia"
				Escribir "Precio: Q", precio * e
			SiNo
				Escribir "Precio no aceptado"
			FinSi
			
		4:
			Escribir "Ingrese el precio: "
			Leer p
			Si p >= 30 Y p <= 50 Entonces
				Escribir "Lugar - Generales"
				Escribir "Precio: Q", precio * e
			SiNo
				Escribir "Precio no aceptado"
			FinSi
			
		De Otro Modo:
			Escribir "Opcion no registrada"
	FinSegun
FinAlgoritmo