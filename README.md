<h3 align="center">Melissa Maribel Quiñonez Mieles</h3>


<h1 align="center"><b>Mapas Mentales y Documentación en README.md</b></h1>



<h3 align="center">Aplicaciones Distribuidas</h3>


Este proyecto resume conceptos clave del desarrollo de software moderno, como aplicaciones distribuidas, Web API, principios SOLID, arquitectura en capas, programación asíncrona y herramientas como Docker y Kubernetes. Incluye un mapa mental y conclusiones para facilitar su comprensión

<h3 align="center">Qué es una API Gateway?</h3>

El Patrón API Gateway es una arquitectura en la que se utiliza un único punto de entrada para que los clientes (web, móvil, etc.) se comuniquen con múltiples servicios del backend

<h3 align="center">RabbitMQ?</h3>

Es un sistema de mensajería (message broker) que permite que diferentes aplicaciones se comuniquen entre sí enviando y recibiendo mensajes a través de cola

<h3 align="center">Entity Framework Core?</h3>

Es una librería creada por Microsoft que nos permite acceder a las bases de datos, principalmente relacionales, de una forma muy simple. 

<h3 align="center">¿Qué es DbContext y DbSet</h3>

<p align="center">
DbContext es una clase abstracta que se puede heredar para crear una clase concreta que represente el contexto de la base de datos de nuestra aplicación. Esta clase concreta se utiliza para configurar la conexión a la base de datos, definir las entidades que se almacenarán en la base de datos y aplicar cambios en la base de datos.
</p>

<h3 align="center">Database First</h3>

<p align="center">
El enfoque Database First significa que primero se crea la base de datos y luego se genera el modelo de Entity Framework Core a partir de ella.
</p>

<h3 align="center">Code Firstt</h3>
<p align="center">
El enfoque code first en Entity Framework core significa que se diseñan y se programan las clases de nuestro modelo de datos en código, y luego Entity Framework Core crea la base de datos, o las tablas correspondientes a partir de dichas clases.
</p>

<h3 align="center">Claves foráneas</h3>
<p align="center">
Una clave foránea (Foreign Key) es un campo en una tabla que hace referencia a la clave primaria de otra tabla, estableciendo una relación entre ambas.
</p>


<img width="996" height="679" alt="image" src="https://github.com/user-attachments/assets/42153b50-72b2-4e22-8b24-f507e830fa04" />



<h3 align="center">Conclusión personal</h3>

<p align="center">
En mi opinión, todos estos temas son muy importantes porque ayudan a entender cómo funcionan las aplicaciones modernas. las aplicaciones distribuidas permiten trabajar con varios sistemas al mismo tiempo, y que herramientas como API Gateway y RabbitMQ facilitan la comunicación entre ellos.

 Entity Framework Core hace más fácil trabajar con bases de datos, y que conceptos como DbContext, DbSet, Database First y Code First ayudan a organizar mejor la información. Además, las claves foráneas son importantes para mantener relaciones correctas entre los datos.
En general, estos conocimientos son fundamentales para desarrollar aplicaciones más organizadas, eficientes y preparadas para el mundo real.



</p>
<h3 align="center">Web API</h3>

<p align="center">
Una API es el punto de entrada del exterior a tu proyecto.
</p>

<h3 align="center">Métodos HTTP (GET, POST, PUT, DELETE, OPTIONS</h3>

<p align="center">
Los métodos HTTP son acciones que indican qué operación se quiere realizar sobre un recurso en un servidor (como una API).
</p>

<p align="center">
  <img width="2048" height="1639" alt="image" src="https://github.com/user-attachments/assets/1ad2d57e-4d8c-41f4-b6ea-9264bafcd2dd" />
</p>


<h3 align="center">Códigos de respuesta (40x, 50x)</h3>
<p align="center">
Los códigos de respuesta HTTP 40x y 50x son mensajes que envía un servidor para indicar que algo salió mal al procesar una solicitud.


 <h3 align="center">Códigos 40x (Errores del cliente)</h3>

Estos indican que el problema está en la solicitud que hizo el usuario o cliente (por ejemplo, un navegador o aplicación).

 <h3 align="center">Códigos 50x (Errores del servidor)</h3>

Estos indican que el problema está en el servidor, aunque la solicitud del cliente sea correcta.
</p>

 <h3 align="center">Diferencia entre DTO y entidad</h3>

<p align="center">
 Un DTO es un “Data Transfer Object” y es el objeto que vamos a devolver desde nuestras API hacia otros servicios. Y únicamente debe contener datos, nada de lógica de negocio. 
</p>
<p align="center">
 
 Una entidad se compone de dos puntos

*Un objeto que representa datos de la base de datos; Como podría ser un objeto que represente cada fila de la base de datos.


*Entidad que encapsula reglas críticas de nuestra aplicación que están relacionadas con este objeto. Y que pueden contener cierta lógica de negocio. 
</p>

 <h3 align="center">Estructura de una aplicación</h3>

<p align="center">
 Es la distribución lógica y física del código, donde cada parte cumple una función específica (interfaz, lógica, datos, etc.), permitiendo que la aplicación sea ordenada, entendible y eficiente.
</p>
<p align="center">
  <img width="416" height="499" alt="image" src="https://github.com/user-attachments/assets/59a0353d-be07-440f-ad2e-b6dedb52fa50" />
</p>
 
<h3 align="center">Inyección de dependencias</h3>

<p align="center">
La inyección de dependencias nos permite crear aplicaciones que son mucho más fáciles de mantener y trabajar en ellas. 
Además debido a las abstracciones nos permite crear interfaces que nos ayudan a la hora de crear test. 
El código es mucho más limpio y legible.  
</p>


<img width="886" height="508" alt="image" src="https://github.com/user-attachments/assets/b5d387fd-fa21-4889-9cfd-24bd866bb1a2" />

 <h3 align="center">Principios SOLID</h3>

 <p align="center">
SOLID es un acrónimo que representa cinco principios que buscan reducir la complejidad y mejorar la calidad del software.

</p>

<img width="886" height="498" alt="image" src="https://github.com/user-attachments/assets/2da87a5f-403b-42db-9be5-7b6fe2dcab63" />


 <h3 align="center">Conclusión personal</h3>

 <p align="center">
  En conjunto, todos estos conceptos forman la base del desarrollo de software moderno, permitiendo crear aplicaciones escalables, eficientes y fáciles de mantener en entornos reales
</p>
URL Imagen

 https://lucid.app/lucidspark/79b8d51f-e290-456e-a7d8-e4624cfe427d/edit?viewport_loc=-3040%2C-843%2C5273%2C2506%2C0_0&invitationId=inv_0d990ff7-fe75-420f-943d-c5d24d19a3b4

 https://canva.link/o21yu1fctwk9591

 https://canva.link/z94yxfhlleo6vp6

