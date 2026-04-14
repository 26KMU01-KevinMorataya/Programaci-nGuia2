Algoritmo impresiones
	Definir c, op Como Entero
	Definir pU, iva, pCIVA Como Real
	Definir tSD, d , tPagar Como Real
	Definir formaP Como Caracter
	pU <- 650
	iva <- 0.12
	Escribir "Se venden impresoras"
	Escribir "Ingrese cuantas impresoras "
	Leer c
	
	Escribir "Forma de pago:"
	Escribir "1. Efectivo (10%)"
	Escribir "2. Tarjeta de credito (5%)"
	Escribir "3. Vale de regalo (15%)"
	Leer op
	
	pCIVA = pU + (pU * iva)
	
	
	tSD = c * pCIVA
	
	
	Segun opcion Hacer
		1:
			d = tSD * 0.10
			formaP = "Efectivo"
		2:
			d = tSD * 0.05
			formaP = "Tarjeta de credito"
		3:
			d = tSD * 0.15
			formaP = "Vale de regalo"
		De Otro Modo:
			Escribir "Digite otra opcion"
	FinSegun
	

	tP <- tSD - d
	
	Escribir "Detalles"
	Escribir "Cantidad de impresoras: ", c
	Escribir "Precio unitario con IVA: Q", pCIVA
	Escribir "Total sin descuento: Q", tSD
	Escribir "Forma de pago: ", formaP
	Escribir "Descuento: Q", d
	Escribir "Total a pagar: Q", tP
	
FinAlgoritmo
