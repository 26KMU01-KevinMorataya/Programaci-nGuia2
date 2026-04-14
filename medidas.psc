Algoritmo medidas
	Definir op1, op2 Como Entero
	Definir v, m, r Como Real
	
	Escribir "Conversor"
	Escribir "Unidades disponibles:"
	Escribir "1. Metros"
	Escribir "2. Pies"
	Escribir "3. Centimetros"
	Escribir "4. Pulgadas"
	
	Escribir "Seleccione la unidad de ORIGEN: "
	Leer op1
	
	Escribir "Seleccione la unidad de DESTINO: "
	Leer op2
	
	Escribir "Ingrese el valor a convertir: "
	Leer v
	
	Segun op1 Hacer
		1:
			metros <- v
		2:
			metros <- v * 0.3048
		3:
			metros <- v / 100
		4:
			metros <- v * 0.0254
		De Otro Modo:
			Escribir "Digite otra opcion"
	FinSegun
	
	Segun opcionDestino Hacer
		1:
			r <- m
		2:
			r <- m / 0.3048
		3:
			r <- m * 100
		4:
			r <- m / 0.0254
		De Otro Modo:
			Escribir "Digite otra opcion"
	FinSegun
	
	Escribir "Resultado: ", r
FinAlgoritmo
