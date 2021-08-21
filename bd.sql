create database tiendavirtual;
use tiendavirtual;
CREATE TABLE categoria (
    idcategoria int  AUTO_INCREMENT PRIMARY KEY, 
    descripcion VARCHAR(20) ,
    estado VARCHAR(20)  
);
CREATE TABLE producto (
    idproducto BIGINT UNSIGNED AUTO_INCREMENT PRIMARY KEY, 
    descripcion VARCHAR(200) ,
    nombre VARCHAR(200) ,
    imagen VARCHAR(200) ,
    precio decimal(18,2) ,
    stock int ,
    idcategoriacategoria int, 
    estado VARCHAR(20)  ,    
    FOREIGN KEY (idcategoria) references categoria(idcategoria)
);
CREATE TABLE orden (
   idorden BIGINT  AUTO_INCREMENT PRIMARY KEY, 
   fecha datetime,
   dnicliente varchar(20),
   nombres varchar(100)
);
CREATE TABLE detalleorden (
   iddetalle BIGINT UNSIGNED AUTO_INCREMENT PRIMARY KEY, 
   idorden BIGINT ,
   idproducto BIGINT UNSIGNED,
   precio decimal(18,2),
   cantidad int,
   FOREIGN KEY (idproducto) references producto(idproducto),
   FOREIGN KEY (idorden) references orden(idorden)
);

INSERT INTO `producto` VALUES (1,'Descripcion 1','Manzana','https://www.eluniversal.com.mx/sites/default/files/2016/09/07/manzana.jpg',10.00,-1,2,'HABILITADO'),(2,'Descripcion 2','Mandarina','https://cdn1.frutapasion.es/wp-content/uploads/2019/11/mandarina-0.jpg',10.00,94,2,'HABILITADO'),(3,'Descripcion','Zanahoria','https://plazavea.vteximg.com.br/arquivos/ids/226526-450-450/120930.jpg?v=636977898066530000',5.00,46,1,'HABILITADO'),(4,'Descripcion 4','Zapallo','https://image.shutterstock.com/image-photo/green-pumpkin-isolated-on-white-260nw-313689500.jpg',15.00,62,1,'HABILITADO');
INSERT INTO `categoria` VALUES (1,'Verduras','HABILITADO'),(2,'Frutas','HABILITADO');