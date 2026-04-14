Algoritmo Matematicas
	Definir n1, n2 Como Real
	Definir p Como Entero
	Escribir "Ingrese el primer numero"
	leer n1
	Escribir "Ingrese el segundo numero"
	leer n2
	Escribir "1= Suma"
	Escribir "2= Resta"
	Escribir "3= Multiplicacion"
	Escribir "4= Division"
	Escribir "Seleccione: "
	leer p
	Segun p Hacer
		1:
			Escribir "Suma "
			Escribir "El resultado de la operacion es: ", n1+n2
		2:
			Escribir "Resta"
			Escribir "El resultado de la operacion es: ", n1-n2
		3:
			Escribir "Multiplicacion "
			Escribir "El resultado de la operacion es: ", n1*n2
		4:
			Escribir "Division"
			Si n2 <> 0 Entonces
				Escribir "El resultado es: ", n1/n2
			SiNo
				Escribir "No se puede dividir entre 0"
			Fin Si
			
		De Otro Modo:
			Escribir "Eliga otra opcion"
	Fin Segun
FinAlgoritmo