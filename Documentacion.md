<h1 align="center">  Especificación de Requerimientos </hi>


## Nombre Descriptivo del Sistema
### [MULTISERVICIOS GLOBAL CAR](https://github.com/Proyecto-Imaster-Ciclo-3/MultiserviciosGlobalCar)




## Equipo de Trabajo
![](https://talentodigital.mintic.gov.co/734/channels-633_logo_talento_digital.svg)

[JESUS GABRIEL TOLOSA ZABALA](https://github.com/gabotolosa)

[JUAN DAVID VILLAMIL MORA](https://github.com/judavimo17)

[ALBA YANETH NIÑO QUINTERO](https://github.com/albanino)

[YESSICA VIVIANA DUARTE FINO](https://github.com/vivdu)

![](https://img.shields.io/github/tag/pandao/editor.md.svg) ![](https://img.shields.io/github/release/pandao/editor.md.svg) ![](https://img.shields.io/github/issues/pandao/editor.md.svg) ![](https://img.shields.io/bower/v/editor.md.svg)


## Roles 
| Integrante  | Roles  | Correo Electronico |
| :------------ |:---------------:| -----:|                    
|Jesus Tolosa  | Lider Equipo | ing.tolosa@gmail.com
|Juan Villamil  | Gestor Base Datos |juandvm17@gmail.com
|Alba Yaneth Niño | Desarrollador Back |ayninoq@gmail.com
|Viviana Duarte| Desarrollador Front |yvduartef@gmail.com


<h1 align="center"> Dominio del sistema </h1>


La empresa en cuestión tiene como visión mantener confianza en sus clientes para el cuidado personalizado en sus vehículos, para ello requiere un sistema donde los clientes puedan solicitar su ayuda a la mano de un clic y puedan estar confiados 24/7 ante cualquier eventualidad, para ellos los clientes pueden adquirir nuestros paquetes o planes que pueden pagar mensual, trimestral, semestral o anual que van desde el lavada d sus vehículos a domicilio, revisión técnico mecánica personalizada, ayudas en procesos legales y documentación, hasta recogida en grúa desde cualquier lugar de la ciudad y área metropolitana sin ningún costo adicional 

## Nuestros planes de subscripcion son: 

| Tipo de Vehiculo  | Mensual  | Trimestral | Semestral | Anual |
| :------------ |:---------------:|:---------------:|:---------------:| :------:|   
| Moto baja cilindradas | 40.000 | 90.000| 180.000 | 300.000 
| Moto cilindrada + 500cc | 50.000 |100.000 |190.000 |400.000
| Vehiculos comerciales | 70.000 | 180.000 | 300.000 | 500.000
| Camperos/Camionetas | 100.000| 250.000 | 400.000 | 700.000
|Autobus/Busetas | 120.000 | 300.000 | 500.000 | 1.000.000
|Camion/Furgon| 200.000 | 500.000 | 900.000 | 1.600.000 
                 

Los clientes q estén activos en su suscripción tienen los siguientes beneficios:

- 2 lavadas gratis mensuales en sus instalaciones o a domicilio
- 1 servicio preventivo mensual sin costo (cambio aceite, cambio líquido refrigerante, filtro, cambio frenos) en sus instalaciones
- Servicio grúa 24/7 desde cualquier parte de la ciudad y su área metropolitana 
- Diagnostico gratis de expertos de cualquiera de nuestros servicios especializados en sus instalaciones citando previamente

Servicios expertos: 
- Latonería, pintura y embellecimiento
- Mecánica general
- Sistema eléctrico (luces, pito, encendido, alarma, sonido)
- Asesorías d procesos legales y documentación (traspasos, impuestos, soat, tecno mecánica, cambio de ciudad, chatarisacion)
- Revisión gas aire acondicionado
- Mecánica preventiva (cambio aceite, cambio líquido refrigerante, filtro)

La suma de todos los servicios solicitados compone un historial del vehículo.

los clientes que no se encuentren con una membresia activa tendra que asumir el costo del servicio solicitado, toda consulta con nuestros servicios de expertos tiene un costo de $ 50.000


|Tipo de Vehiculo | Lavada | Servicio Preventivo | Servicio de grua |
|:--------------|:-----------:|:----------:|:----------:|
| Moto baja cilindradas | 10.000 | 50.000| 50.000
| Moto cilindrada + 500cc | 20.000 |100.000 |70.000
| Vehiculos comerciales | 20.000 | 100.000 | 140.000
| Camperos/Camionetas | 50.000| 250.000 | 160.000
|Autobus/Busetas | 70.000 | 250.000 | 180.000
|Camion/Furgon| 70.000 | 300.000 | 250.000 



<h1 align="center"> Descripción del Diseño</h1>

### Requisitos

El funcionamiento de la aplicación es el siguiente:

Al iniciar, se abrirá una pantalla informativa de los servicios que presta la empresa y tendrá un lugar para inicio de sesión, y registro, en la que el usuario tendrá que logearse a partir del documento y una contraseña para ingresar al menú principal del sistema. Si el usuario no está registrado, podrá registrarse como cliente nuevo y llenar un formulario de inscripción, una vez ingresado el usuario nuevo se dirigirá a ingresar un vehículo para tener acceso a todo el sistema, un cliente tiene los siguientes atributos (nombre, apellido, cedula, contraseña, teléfono, correo y dirección) 

La primera página tendrá: información de la empresa y los servicios que presta, entrar al sistema y registrarse al sistema


Tras el login, aparecerá la pantalla principal de la aplicación, donde se mostrará el tablero del usuario donde podrá interactuar con las diferentes funciones del sistema, el usuario podrá modificar solo los siguientes atributos: contraseña, teléfono, dirección y correo, si su estado es activo podrá solicitar sus servicio preventivo sin costo (lavada, cambio aceite, cita de solicitud servicio especializado o servicio grúa), podrá consultar su historial de servicios de su vehículo, podrá ingresar otro vehículo o eliminarlo y finalmente el usuario podrá darse de baja eliminando su cuenta ingresando su numero de documento y cedula para verificar su identidad

El usuario podrá consultar los datos de los especialistas desde solicitar servicios (nombre, apellido, especialidad) y los servicios que presta

Se tendrán una base de datos con los especialistas y se llenara mediantes sentencia SQL desde el editor de base d datos utilizado durante el ciclo, si alcanza el tiempo se podría implementar un formulario CRUD para interactuar con los especialistas

El maquop del sistema lo puede consultar en el siguiente enlace [https://multiserviciosglobalcar/home](https://app.moqups.com/4pRHo6LzbkrLMu4CuIvGJLrWCLWIN9AI/view/page/a5ec1f375)

Los diagramas del sistema lo puedes consultar en el siguiente enlace [https://www.multiserviciosglobalcar/Diagramas](https://viewer.diagrams.net/?tags=%7B%7D&highlight=0000ff&edit=_blank&layers=1&nav=1&page-id=jmDnNmUA80Y7p93uCzOF&title=Diagrama%20sin%20t%C3%ADtulo%20drawio.html#G1Wg6vq2D67Z42oyh-EkzBnOz0WoRgrSwu)
