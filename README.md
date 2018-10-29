# examen3EFJY
Previamente he instalado entityframework desde la consola de nuget.  

declaramos las clases ingredientsy pizzas y sus attributos. Price es un tipo decimal para ser más preciso con los decimales.En app.config insertamos con appsettings una clave key "discount" con valor 1.2 para poder aplicarle el 20% al precio de los ingredientes
y ,previamente, enreferencias referenciamos configurationmanager.  

Con Icollection relacionamos las tablas pizzas e ingredientes de manera many to many.  

Usaremos Ienumerable para paginar las pizzas
