# Controles_Moviles_Unity
Controles para juegos en dispositivos móviles hechos con Unity

*********************************************************************************

Para el control con botones UI es necesario crear un canvas y crear dentro de el 
un elemento tipo buttom UI en donde se crearan 4 event trigger, para añadir los eventos
seleccionamos el boton > en inspector add component y seleccionar event > event trigger
y agregar:

-Pointer Down
-Pointer Up
-Pointer Enter
-Pointer Exit

y asignarle los metodos que ejecutaran y el objeto que controlara por ejemplo:

Al boton para mover hacia la derecha, le asignaremos el metodo MoverDerecha() en
el event trigger Pointer Down, y Detener() al event trigger Pointer Up y de la misma
manera a los eventos Pointer Enter y Pointer Exit.

*********************************************************************************

Para asignar el control por Input.Touch y por acelerometro simplemente se llamara el
metodo del control que se usara en el metodo Update() los metodos son los siguientes:

-MovimientoAcelerometro();
-MovimientoTouch();
