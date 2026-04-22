Algoritmo Ejercicio5
    Definir cant Como Entero
    Definir pUnit, pIVA, sub, desc, tot Como Real
    Definir fp Como Entero
    Definir nomFP Como Cadena
	
    pUnit <- 650
    pIVA <- pUnit * 1.12
	
    Escribir "=== VENTA DE IMPRESORAS T&S ==="
    Escribir "Precio unitario sin IVA: Q", pUnit
    Escribir "Precio unitario con IVA: Q", pIVA
	
    Escribir "Cantidad de impresoras:"
    Leer cant
	
    Escribir "Forma de pago:"
    Escribir "1 - Efectivo (10%)"
    Escribir "2 - Tarjeta de crédito (5%)"
    Escribir "3 - Vale de regalo (15%)"
    Leer fp
	
    sub <- pIVA * cant
	
    Segun fp Hacer
        1:
            desc <- sub * 0.10
            nomFP <- "Efectivo"
        2:
            desc <- sub * 0.05
            nomFP <- "Tarjeta de crédito"
        3:
            desc <- sub * 0.15
            nomFP <- "Vale de regalo"
        De Otro Modo:
            Escribir "Forma de pago inválida"
            desc <- 0
            nomFP <- "N/A"
    FinSegun
	
    tot <- sub - desc
	
    Escribir "=== DETALLE DE COMPRA ==="
    Escribir "Cantidad: ", cant
    Escribir "Precio unitario (IVA incluido): Q", pIVA
    Escribir "Subtotal: Q", sub
    Escribir "Forma de pago: ", nomFP
    Escribir "Descuento: Q", desc
    Escribir "Total a pagar: Q", tot
	
FinAlgoritmo