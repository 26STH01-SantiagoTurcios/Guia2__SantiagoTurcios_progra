Algoritmo Ejercicio4
    Definir valor, resultado Como Real
    Definir Origen, Destino Como Entero
	
    Escribir "=== CONVERSOR DE LONGITUD ==="
    Escribir "Unidades: 1-Metros  2-Pies"
    Escribir "          3-Centimetros  4-Pulgadas"
	
    Escribir "Unidad de origen:"
    Leer Origen
	
    Escribir "Valor a convertir:"
    Leer valor
	
    Escribir "Unidad de destino:"
    Leer Destino
	

    Segun Origen Hacer
        1:
            resultado <- valor
        2:
            resultado <- valor * 0.3048
        3:
            resultado <- valor / 100
        4:
            resultado <- valor * 0.0254
        De Otro Modo:
            Escribir "Error: unidad de origen no válida"
            resultado <- -1
    FinSegun
	
    Si resultado >= 0 Entonces
		
        Segun Destino Hacer
            1:
                Escribir resultado, " metros"
            2:
                Escribir resultado / 0.3048, " pies"
            3:
                Escribir resultado * 100, " cm"
            4:
                Escribir resultado / 0.0254, " pulgadas"
            De Otro Modo:
                Escribir "Error: unidad de destino no válida"
        FinSegun
		
    FinSi
	
FinAlgoritmo