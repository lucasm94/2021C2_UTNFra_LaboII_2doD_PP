# Título
# CiberCafe Messirve
*UTNFra Laboratorio de Computación II - Primer Parcial - Comisión 2do D - 2do cuatrimestre 2021*

[Enunciado del parcial](https://codeutnfra.github.io/programacion_2_laboratorio_2_apuntes/docs/evaluaciones/parciales/2d-primer-parcial/)

## Sobre mí
Mi nombre es Lucas Monzón tengo 27 años. Tengo experiencia como programador y estor recursando la materia. 
Para mí el parcial no fue tan dificil en lo requerido sino que la dificultad estuvo en el tiempo que se necesitaba 
para cumplir con todos los puntos de aprobación. Me resulto divertido el tener que pensar una solución end to end.
Me hubiera gustado poder agregarle mas cosas a los forms como por ejemplo sonido.

## Resumen
La aplicación permite la gestión de un Ciber, en la cual se podrán asignar y facturar cabinas telefónicas y maquinas de computación.
Tambien te permite ver estadisticas como realizar copias.

Cuenta con un menu en el cual podemos:
 Ver los dispositivos(telefonos y computadoras).
 Ver los clientes(en espera, atendidos y usando algun servicio), asignar servicio y cobrar.
 Ver las estadisticas del ciber.
 Ver y realizar copias.

## Diagrama de clases
[Diagrama de clases](https://github.com/lucasm94/2021C2_UTNFra_LaboII_2doD_PP/blob/master/Monzon.Lucas.PrimerParcial/Entidades/DiagramaDeClases.png)

## Justificación técnica
El programa fue realizado en c# y .NET, con el paradigma de la programación orientada a objetos.
Con respecto a los pilares de la programación orientada a objetos: 
 - La clase Cliente es una clase abstracta y de ella hereda ClienteComputadora. Utilice esta herencia dado que existen clientes para 
 realizar llamados y otros para utilizar computadoras de los cuales necesitamos la misma informacion salvo que del segundo nos interesa 
 saber que softwares, perifericos, juegos requiere.
 - La clase Dispositivo es una abstracta de la cual heredan Computadoras y Telefonos. Estos tienen informacion basica compartida pero 
 tienen algunos atributos y comportamientos distintos.
 - La clase Servicio es otra clase abstracta que tiene como hijas a la clase Cabina y Maquina, basicamente comparten la informacion tipica de un 
 servicio como el inicio, el final, el monto a pagar pero difiere lo que seria el cobro, ambas tienen distintas maneras de cobrar.
 - En todas las clases se utiliza el Encapsulamiento brindando solo la informacion necesaria para las clases que las utilicen.
 - La sobracarga se utilizo por ejemplo en el metodo que calcula el costo a cobrar al cliente.

Forms:
Se utliizaron 8 formularios, los cuales 7 heredan de el formulario base FrmBase, que contiene la informacion del usuario y la fecha.
 - Menu principal: FrmMenu.
 - Ver Dispositivos: FrmDispositivo.
 - Ver Clientes: FrmCliente.
 - Ver Estadisticas: FrmEstadisticas.
 - Ver Copias: FrmCopias.
 - Asignar Cabina: FrmAsignarCabina.
 - Asignar Maquina: FrmAsignarMaquina.

## Propuesta de valor agregado
Se agrego una opción extra la cual es que se podran realizar copias de juegos.
En este caso el cliente indica al usuario del ciber que juego quiere copiar y cuantas copias necesita.
Esta propuesta se debe a la alta demanda que habia en los 2000 de copias tanto de juegos, peliculas como musica.