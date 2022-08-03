<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WEB_NET_Aplication.data.Default" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <form runat="server">
        <main>
            <div class="container">
                <section>
                    <h3 class="mb-4 dark-grey-text font-weight-bold"><strong>Pasos a seguir para usar la aplicacion. </strong></h3>
                    <div class="row mb-5">
                        <div class="col-lg-4 col-md-6 mb-4">
                            <div class="card card-cascade wider card-transparent">
                                <div class="view view-cascade gradient-card-header info-color-dark">
                                    <h3 class="card-header-title mb-2"><strong>Paso 1</strong></h3>
                                    <h4 class="card-header-title mb-2">Registrar Colores</h4>
                                </div>
                                <div class="card-body card-body-cascade ext-center">
                                    <p class="card-text mr-2 ml-2 pb-1">Al registrar los colores solo introducir el nombre del color tal como: Rojo, Azul, Blanco, etc...</p>
                                    <a href="color_register.aspx" class="orange-text mt-1 d-flex flex-row-reverse">
                                        <h5 class="waves-effect p-2"><i class="fas fa-caret-right fa-2x"></i></h5>
                                    </a>
                                </div>
                            </div>
                        </div>
                        <div class="col-lg-4 col-md-6 mb-4">
                            <div class="card card-cascade wider card-transparent">
                                <div class="view view-cascade gradient-card-header primary-color-dark">
                                    <h3 class="card-header-title mb-2"><strong>Paso 2</strong></h3>
                                    <h4 class="card-header-title mb-2">Registrar Tipos</h4>
                                </div>
                                <div class="card-body card-body-cascade ext-center">
                                    <p class="card-text mr-2 ml-2 pb-1">Al momento de registrar los tipos solo insertar el nombre de tipo de producto por ejemplo : Televisor, Celular, Microondas, etc...</p>
                                    <a href="type_register.aspx" class="orange-text mt-1 d-flex flex-row-reverse">
                                        <h5 class="waves-effect p-2">
                                            <!-- registrar_color.asp-->
                                            <i class="fas fa-caret-right fa-2x"></i></h5>
                                    </a>
                                </div>
                            </div>
                        </div>
                        <div class="col-lg-4 col-md-6 mb-4">
                            <div class="card card-cascade wider card-transparent">
                                <div class="view view-cascade gradient-card-header unique-color-dark">
                                    <h3 class="card-header-title mb-2"><strong>Paso 3</strong></h3>
                                    <h4 class="card-header-title mb-2">Registrar Productos</h4>
                                </div>
                                <div class="card-body card-body-cascade ext-center">
                                    <p class="card-text mr-2 ml-2 pb-1">Cuando se registren los anteriores modulos, se podra registrar algun producto que contiene, nombre, precio, calificacion, tipo, color, descripcion y alguna imagen. </p>
                                    <a href="products_register.aspx" class="orange-text mt-1 d-flex flex-row-reverse">
                                        <h5 class="waves-effect p-2"><i class="fas fa-caret-right fa-2x"></i></h5>
                                    </a>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="row mb-5">
                        <div class="col-lg-12 col-md-12 mb-4">
                            <div class="card card-cascade wider card-transparent">
                                <div class="view view-cascade gradient-card-header success-color">
                                    <h2 class="card-header-title mb-2">Paso 4: Visualizar productos</h2>
                                </div>
                                <div class="card-body card-body-cascade ext-center">
                                    <a href="#" class="orange-text mt-1 d-flex flex-row-reverse">
                                        <h5 class="waves-effect p-2">
                                            <!-- registrar_color.asp-->
                                            <i class="fas fa-caret-right fa-2x"></i></h5>
                                    </a>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="row mb-5">
                        <div class="col-lg-4 col-md-4">
                            <div class="card card-cascade">
                                <div class="view view-cascade overlay">
                                    <img src="https://scontent.fcxl1-2.fna.fbcdn.net/v/t1.6435-9/140152290_4014327911912132_7403048239453912324_n.jpg?_nc_cat=104&amp;ccb=1-7&amp;_nc_sid=174925&amp;_nc_eui2=AeEBovrG76cXDqnwZv-0T3ixlXfBhMxNUN2Vd8GEzE1Q3abySUVvixZvQ3BwPqzcfC54JOQgOXMwogI8i8NLdmJ-&amp;_nc_ohc=JjbfEmxnMlcAX8sxziD&amp;_nc_ht=scontent.fcxl1-2.fna&amp;oh=00_AT-zMMaGkBTVbdTIhCQpGvAyMgSlb6OTFIn7w-Mx39_tTA&amp;oe=630FBA3D" class="card-img-top" alt="">
                                    <a>
                                        <div class="mask rgba-white-slight waves-effect waves-light"></div>
                                    </a>
                                </div>
                                <div class="card-body card-body-cascade text-center">
                                    <h4 class="card-title"><strong>Darien Ramirez Perez</strong></h4>
                                    <h5>Programador - Diseñador web</h5>
                                    <p class="card-text">
                                        Egresado del Instituto Tecnologico de Nogales,
                                      Con dominio de lenguajes para programacion en backend y frontend como 
                                      HTML, CSS, JavaScript, Jquery, ASP.NET, C#, Laravel, React, PHP y en Bases de datos como 
                                      SQL SERVER, MY SQL y SQL Lite
                                    </p>
                                </div>
                            </div>
                        </div>

                        <div class="col-lg-8 col-md-8 mt-2">
                            <div class="card">

                                <div class="card-body card-body-cascade">
                                    <h4 class="card-title"><strong>Un poco sobre la aplicacion</strong></h4>
                                    <p class="card-text">
                                        El proposito de la aplicacion es un ejemplo del sistema CRUD que consiste en 
                                        mostrar, editar, eliminar y crear informacion con diferentes formularios, los cuales fueron creados desde cero,
                                        las tablas y la muestra de los productos de esta aplicacion fueron creados desde cero y no se uso ningun tipo de plugin para
                                        visualisarlos.
                                  
                                    </p>
                                    <p class="card-text">
                                        Esta aplicacion fue realizada en ASP.NET usando HTML,CSS,Jquery y SQL Server, el cual por la parte
                                        del servidor fue hosteado en la nube usando los servicios de Microsoft Azure para fines practicos y facil revision del proyecto,
                                        que fue subido a un repositorio en <a href="https://github.com/DarienRamirez/WEB-NET-Aplication.git">Github</a>.
                                    </p>
                                </div>
                            </div>
                            <div class="card mt-5">
                                <div class="card-body card-body-cascade">
                                    <h4 class="card-title"><strong>Contacto:</strong></h4>
                                    <p>
                                        Telefono: <strong>+52 6311113795 </strong>
                                    </p>
                                    <p >
                                        Correo:<a href = "mailto: darienramirezperez@outlook.com"> <strong>darienramirezperez@outlook.com </strong></a>
                                    </p>
                                    <p>
                                        Direccion: <strong>Cabeco #300, Centro, 84020 Nogales, Sonora Mexico</strong>
                                    </p>
                                    <p>
                                        Nacionalidad: <strong>Ciudadano Americano</strong>
                                    </p>
                                    <p>
                                        Fecha de nacimiento: <strong>29 de Julio de 1997, 25 Años</strong>
                                    </p>
                                </div>
                            </div>
                        </div>
                    </div>
                </section>
            </div>
        </main>
    </form>
</asp:Content>
