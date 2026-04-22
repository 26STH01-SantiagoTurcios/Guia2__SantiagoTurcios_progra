Algoritmo Ejercicio3
    Definir sec, cantidad Como Entero
    Definir pr, to Como Real
	
    Escribir "=== ENTRADAS ESTADIO ==="
    Escribir "1 - Palco"
    Escribir "2 - Tribuna"
    Escribir "3 - Preferencia"
    Escribir "4 - Generales"
    Escribir "Seleccione sector:"
    Leer sec
	
    Escribir "Cantidad de entradas:"
    Leer cantidad
	
    Segun sec Hacer
        1:
            pr <- 300.00
            Escribir "Sector: Palco"
			
        2:
            pr <- 112.50
            Escribir "Sector: Tribuna"
			
        3:
            pr <- 62.50
            Escribir "Sector: Preferencia"
			
        4:
            pr <- 40.00
            Escribir "Sector: Generales"
			
        De Otro Modo:
            Escribir "Sector no valido"
            pr <- 0
    FinSegun
	
    Si pr > 0 Entonces
        to <- pr * cantidad
        Escribir "Precio por entrada: Q", pr
        Escribir "Entradas: ", cantidad
        Escribir "Total a pagar: Q", to
    FinSi
	
FinAlgoritmo