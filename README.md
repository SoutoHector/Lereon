# Lereon
School project - Application that organised and help the work of restaurants.

12/10/2019
  - Creación de una interfaz básica
13/10/2019  
  - Inclusión de un código de prueba para introducir un password para poder acceder al menú base
17/10/2019
  - Creación de la interfaz de registro y conectarla a través de la pantalla de autentificación 
desde 18/10/2019 hasta actualmente
  - Trabajo con sqlite para integrar una base de datos para el registro y autentificación en la aplicacion
29/10/2019
  - Creación de una base de datos para los guardar los platos del menú. Incorporando el ID del plato, el nombre, una imagen acompañada y      la moneda de pago.
31/10/2019
  - Creación de un nuevo componente nuevo denominado plato que tendra un picturebox para mostrar la imagen del plato, dos label para indicar el nombre y la moneda, y un botón para añadir el coste del plato al precio final.
  
1/11/2019 
  - Cambios en la interfaz principal: uso de splitcontainer, para en futura actualización realizar los cambios de los botones de la columna de la izquierda en la columnna de la derecha sin la necesidad de crear formularios a parte.
  
2/11/2019 a 4/11/2019
  - Creación y funcionamiento de la calculadora que se accede desde el boton con dicho nombre de el programa principal. Espero actualizarlo para que funcione por teclado y sin tener que usar un formulario. Añadir en avisos un contador, cada vez que se pulsa el botón de enviar aviso.

7/11/2019 
  - Creación de las clases Trabajador y Platos para con variables, set y get para crear List con esas clases y ser usadas para el registro y mostrar los platos.
  
8/11/2019
  - Creación de las consultas y lists necesarias para acceder a los datos guardados en la base de datos.
  
9/11/2019 a 11/11/2019
  - Implementación del código, el cual, permite en la pantalla autentificación poder acceder a la aplicación si el usuario y contraseña se encuentran registrados en la base de datos. Además se ha añadido un bloqueo al botón opciones, permitiendo que solo el jefe o dueño que conozca el usuario y contraseña de administrador, pueda acceder a las funcionalidades de dicho botón que serán implementadas. 

12/11/2019
- Integración de la pantalla de registro par introducir nuevos trabajadores en la aplicación.

14/11/2019
- Creación de código para mostrar en formato de lista los platos de las bases de datos a través de imagen, nombre y precio.

19/11/2019
- Creación de la calculadora en los split container de windows form para reducir el número de ventanas a la hora de usar la aplicación y facilitar su uso a la vez que optimizarlo.

20/11/2019
- Gestión del sistema de comandas, el cual mustra las comandas enviadas a través de los envíos de la opción menú.

21/11/2019

- Eliminación de el botón de avisos, sustituido por un botón que muestra el total de los beneficios de las comandas cobradas. Pasando así los avisos de las comandas que hay, a el botón de comandas. Creación de un componente para las comondas, para un mejor uso.

22/11/2019
- Creación y gestión de el botón de opciones del administrador que permite meter o sacar nuevos trabajadores y platos del menú. Siendo 
él, el único que pueda utilziar ese modo.

23/11/2019
- Corrección de fallos e intento de cubrir todos los posibles errores que puedan surgir de la aplicación. 
