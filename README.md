# Controles_Moviles_Unity
Controles para dispositivos móviles

*********************************************************************************

Para el control con botones UI es necesario crear 4 event trigger:

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
