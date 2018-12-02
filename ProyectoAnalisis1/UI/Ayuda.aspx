<%@ Page Title="" Language="C#" MasterPageFile="~/mainMaster.Master" AutoEventWireup="true" CodeBehind="Ayuda.aspx.cs" Inherits="UI.Ayuda" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<br />
    <div class="container">
        <br />
        <div class="form-group">
            <asp:Label ID="Label1" runat="server" ForeColor="#16ACB8" Text="Ayuda del sistema" Font-Size="XX-Large"></asp:Label>
        </div>
        <br />
        <br />


        <div class="accordion" id="accordionExample">
            <div class="card">
                <div class="card-header" id="headingOne">
                    <h5 class="mb-0">
                        <button class="btn btn-link" type="button" data-toggle="collapse" data-target="#collapseOne" aria-expanded="true" aria-controls="collapseOne">
                            Crear nuevo expediente
                        </button>
                    </h5>
                </div>

                <div id="collapseOne" class="collapse show" aria-labelledby="headingOne" data-parent="#accordionExample">
                    <div class="card-body">
                        <ol type="1">
                            <li>En la página principal, dé click en el botón "Crear nuevo expediente"</li>
                            <li>Complete la información necesaria del paciente.</li>
                            <li>Dé click en el botón "Guardar"</li>
                        </ol>
                    </div>
                </div>
            </div>
            <div class="card">
                <div class="card-header" id="headingTwo">
                    <h5 class="mb-0">
                        <button class="btn btn-link collapsed" type="button" data-toggle="collapse" data-target="#collapseTwo" aria-expanded="false" aria-controls="collapseTwo">
                            Buscar un expediente
                        </button>
                    </h5>
                </div>
                <div id="collapseTwo" class="collapse" aria-labelledby="headingTwo" data-parent="#accordionExample">
                    <div class="card-body">
                        <ol type="1">
                            <li>Diríjase a la página principal, en la sección "Buscar Expedientes"</li>
                            <li>Los expedientes se pueden buscar por "Cédula" o por "Nombre"</li>
                            <li>En busqueda por cédula: Digíte la cédula completa o parte de esta en el campo "Buscar por Cédula" y dé click en el botón buscar.</li>
                            <li>En busqueda por nombre: Digíte el nombre completo o parte de éste en el campo "Buscar por Nombre" y dé click en el botón buscar.</li>
                        </ol>
                    </div>
                </div>
            </div>
            <div class="card">
                <div class="card-header" id="headingThree">
                    <h5 class="mb-0">
                        <button class="btn btn-link collapsed" type="button" data-toggle="collapse" data-target="#collapseThree" aria-expanded="false" aria-controls="collapseThree">
                            Ver todos los Expedientes
                        </button>
                    </h5>
                </div>
                <div id="collapseThree" class="collapse" aria-labelledby="headingThree" data-parent="#accordionExample">
                    <div class="card-body">
                         <ol type="1">
                            <li>En la página principal, seleccione el botón "Todos Expedientes"</li>
                            <li>Ridirige a la página donde se encuentran en una tabla en la sección "Expedientes" donde se encuentran ordenados alfabéticamente por el primer apellido del paciente</li>
                        </ol>
                    </div>
                </div>
            </div>
            <div class="card">
                <div class="card-header" id="headingFour">
                    <h5 class="mb-0">
                        <button class="btn btn-link collapsed" type="button" data-toggle="collapse" data-target="#collapseFour" aria-expanded="false" aria-controls="collapseFour">
                            Filtrar expediente por Rango de fechas de las consultas
                        </button>
                    </h5>
                </div>
                <div id="collapseFour" class="collapse" aria-labelledby="headingFour" data-parent="#accordionExample">
                    <div class="card-body">
                         <ol type="1">
                            <li>En la página principal, seleccione el botón "Todos Expedientes"</li>
                            <li>Ridirige a otra página donde se encuentran dos calendarios de fecha inicio y de fecha fin</li>
                             <li>Seleccionar el rango de fechas por el que se desea filtrar</li>
                             <li>Dar click en el botón de filtrar</li>
                             <li>El resultado de la búsqueda se puede observar en la tabla de la sección Expedientes, sino encuentra ningún expediente con consultas en ese rango de fechas muestra un mensaje informando el error</li>
                        </ol>
                    </div>
                </div>
            </div>
             <div class="card">
                <div class="card-header" id="headingFive">
                    <h5 class="mb-0">
                        <button class="btn btn-link collapsed" type="button" data-toggle="collapse" data-target="#collapseFive" aria-expanded="false" aria-controls="collapseFive">
                            Agregar expedientes a la lista del día
                        </button>
                    </h5>
                </div>
                <div id="collapseFive" class="collapse" aria-labelledby="headingFive" data-parent="#accordionExample">
                    <div class="card-body">
                         <ol type="1">
                            <li>Opción 1: En la página principal, puede realizar una búsqueda por cédula o nombre y en la tabla darle click a "Agregar"</li>
                            <li>Opción 2: En la página donde se encuentran todos los expedientes, en la tabla de la sección Expedientes darle click a "Agregar" en la fila del expediente que desea agregar</li>
                            <li>Opción 3: En la página donde se encuentran las listas de consultas del expediente, darle click al botón de "Agregar" y dicho expediente se agrega automáticamente a la lista del día</li>
                        </ol>
                    </div>
                </div>
            </div>
            <div class="card">
                <div class="card-header" id="headingSix">
                    <h5 class="mb-0">
                        <button class="btn btn-link collapsed" type="button" data-toggle="collapse" data-target="#collapseSix" aria-expanded="false" aria-controls="collapseSix">
                            Crear una nueva consulta
                        </button>
                    </h5>
                </div>
                <div id="collapseSix" class="collapse" aria-labelledby="headingSix" data-parent="#accordionExample">
                    <div class="card-body">
                         <ol type="1">
                            <li>Seleccionar el expediente al que se desea agregar la consulta</li>
                            <li>Darle click al botón de "Consultas" donde se pueden observar las consultas que tiene al momento el paciente</li>
                            <li>Dar click en el botón "Agregar"</li>
                            <li>Redirige a la página de la consulta donde se pueden realizar las modificaciones necesarias</li>
                        </ol>
                    </div>
                </div>
            </div>
            <div class="card">
                <div class="card-header" id="headingSeven">
                    <h5 class="mb-0">
                        <button class="btn btn-link collapsed" type="button" data-toggle="collapse" data-target="#collapseSeven" aria-expanded="false" aria-controls="collapseSeven">
                            Ver lista de consultas de un expediente
                        </button>
                    </h5>
                </div>
                <div id="collapseSeven" class="collapse" aria-labelledby="headingSeven" data-parent="#accordionExample">
                    <div class="card-body">
                         <ol type="1">
                            <li>Seleccionar el expediente al que se desea consultar la lista de consultas</li>
                            <li>Darle click al botón de "Consultas" donde se pueden observar las consultas que tiene al momento el paciente</li>
                        </ol>
                    </div>
                </div>
            </div>
             <div class="card">
                <div class="card-header" id="headingEight">
                    <h5 class="mb-0">
                        <button class="btn btn-link collapsed" type="button" data-toggle="collapse" data-target="#collapseEight" aria-expanded="false" aria-controls="collapseEight">
                            Crear/Modificar el historial clínico
                        </button>
                    </h5>
                </div>
                <div id="collapseEight" class="collapse" aria-labelledby="headingEight" data-parent="#accordionExample">
                    <div class="card-body">
                         <ol type="1">
                            <li>Seleccionar el expediente al que pertenece el historial clínico</li>
                            <li>Dar clicl en el botón "Historial clínico"</li>
                             <li>Realizar los cambios en el historial clínico</li>
                             <li>Dar click en el botón "Guardar" para guardar los datos del historial clínico</li>
                        </ol>
                    </div>
                </div>
            </div>
              <div class="card">
                <div class="card-header" id="headingNine">
                    <h5 class="mb-0">
                        <button class="btn btn-link collapsed" type="button" data-toggle="collapse" data-target="#collapseNine" aria-expanded="false" aria-controls="collapseNine">
                            Eliminar un expediente de la lista del día
                        </button>
                    </h5>
                </div>
                <div id="collapseNine" class="collapse" aria-labelledby="headingNine" data-parent="#accordionExample">
                    <div class="card-body">
                         <ol type="1">
                            <li>Ir a la página principal</li>
                            <li>En la tabla de la sección "Consultas del día" seleccionar el botón eliminar</li>
                             <li>Se elimina el expediente de la tabla de consultas del día</li>
                        </ol>
                    </div>
                </div>
            </div>
             <div class="card">
                <div class="card-header" id="headingTen">
                    <h5 class="mb-0">
                        <button class="btn btn-link collapsed" type="button" data-toggle="collapse" data-target="#collapseTen" aria-expanded="false" aria-controls="collapseTen">
                            Ver la última consulta creada en el expediente
                        </button>
                    </h5>
                </div>
                <div id="collapseTen" class="collapse" aria-labelledby="headingTen" data-parent="#accordionExample">
                    <div class="card-body">
                         <ol type="1">
                            <li>Buscar y selecciona el expediente</li>
                            <li>Si el expediente no tiene consultas el botón no se va a ver, en caso contrario dar click al botón "Última Consulta"</li>
                             <li>Se muestra la página de la última consulta de dicho expediente</li>
                        </ol>
                    </div>
                </div>
            </div>
            <div class="card">
                <div class="card-header" id="headingEleven">
                    <h5 class="mb-0">
                        <button class="btn btn-link collapsed" type="button" data-toggle="collapse" data-target="#collapseEleven" aria-expanded="false" aria-controls="collapseEleven">
                            Modificar un expediente
                        </button>
                    </h5>
                </div>
                <div id="collapseEleven" class="collapse" aria-labelledby="headingEleven" data-parent="#accordionExample">
                    <div class="card-body">
                         <ol type="1">
                            <li>Buscar y selecciona el expediente que se desea modificar</li>
                            <li>Modificar los datos del formulario de "Datos Personales"</li>
                             <li>Dar click en el botón "Guardar"</li>
                        </ol>
                    </div>
                </div>
            </div>
             <div class="card">
                <div class="card-header" id="headingTwelve">
                    <h5 class="mb-0">
                        <button class="btn btn-link collapsed" type="button" data-toggle="collapse" data-target="#collapseTwelve" aria-expanded="false" aria-controls="collapseTwelve">
                            Guardar el precio de una consulta
                        </button>
                    </h5>
                </div>
                <div id="collapseTwelve" class="collapse" aria-labelledby="headingTwelve" data-parent="#accordionExample">
                    <div class="card-body">
                         <ol type="1">
                             <li>Únicamente los usuarios con el rol de doctor pueden realizar este cambio</li>
                            <li>Dirigirse a la página de la consulta que tiene el precio que se desea guardar</li>
                            <li>Escribir en el espacio de "Precio de consulta" el precio que se desea</li>
                             <li>Dar click en el botón "Guardar"</li>
                        </ol>
                    </div>
                </div>
            </div>
            <div class="card">
                <div class="card-header" id="headingThirteen">
                    <h5 class="mb-0">
                        <button class="btn btn-link collapsed" type="button" data-toggle="collapse" data-target="#collapseThirteen" aria-expanded="false" aria-controls="collapseThirteen">
                            Guardar/Modificar ficha doctor
                        </button>
                    </h5>
                </div>
                <div id="collapseThirteen" class="collapse" aria-labelledby="headingThirteen" data-parent="#accordionExample">
                    <div class="card-body">
                         <ol type="1">
                             <li>Únicamente los usuarios con el rol de doctor pueden realizar estos cambios</li>
                            <li>Dirigirse a la página de la consulta que tiene la ficha de doctor</li>
                            <li>Dar click en el botón "Entrar" de la ficha de doctor</li>
                             <li>Realizar los cambios que se quieran en cada uno de los espacios</li>
                             <li>Se pueden añadir imágenes al final de la ficha dando click en seleccionar archivo, luego seleccionar una imagen que se encuentre en la computadora</li>
                             <li>Dar click en el botón de guardar</li>
                        </ol>
                    </div>
                </div>
            </div>
             <div class="card">
                <div class="card-header" id="headingFourteen">
                    <h5 class="mb-0">
                        <button class="btn btn-link collapsed" type="button" data-toggle="collapse" data-target="#collapseFourteen" aria-expanded="false" aria-controls="collapseFourteen">
                            Guardar/Modificar ficha de paramédico
                        </button>
                    </h5>
                </div>
                <div id="collapseFourteen" class="collapse" aria-labelledby="headingFourteen" data-parent="#accordionExample">
                    <div class="card-body">
                         <ol type="1">
                             <li>Únicamente los usuarios con el rol de doctor y paramédico pueden realizar estos cambios</li>
                            <li>Dirigirse a la página de la consulta que tiene la ficha del paramédico</li>
                            <li>Dar click en el botón "Entrar" de la ficha de paramédico</li>
                             <li>Realizar los cambios que se quieran en cada uno de los espacios</li>
                             <li>Dar click en el botón de guardar</li>
                        </ol>
                    </div>
                </div>
            </div>
            <div class="card">
                <div class="card-header" id="headingFifteen">
                    <h5 class="mb-0">
                        <button class="btn btn-link collapsed" type="button" data-toggle="collapse" data-target="#collapseFifteen" aria-expanded="false" aria-controls="collapseFifteen">
                            Configuración de la cuenta de usuario
                        </button>
                    </h5>
                </div>
                <div id="collapseFifteen" class="collapse" aria-labelledby="headingFifteen" data-parent="#accordionExample">
                    <div class="card-body">
                         <ol type="1">
                             <li>En la barra de navegación seleccionar la opción de "Configuración"</li>
                            <li>Tiene la opción de ver su información básica, además de poder modificar la contraseña y el nombre de usuario</li>
                            <li>Si desea modificar la contraseña debe de escribir su contraseña actual y la nueva</li>
                             <li>Seleccionar el botón de guardar, si la contraseña actual no coincide con la digitada no se va a realizar el cambio de contraseña</li>
                        </ol>
                    </div>
                </div>
            </div>
            <div class="card">
                <div class="card-header" id="headingSixteen">
                    <h5 class="mb-0">
                        <button class="btn btn-link collapsed" type="button" data-toggle="collapse" data-target="#collapseSixteen" aria-expanded="false" aria-controls="collapseSixteen">
                            Cerrar sesión
                        </button>
                    </h5>
                </div>
                <div id="collapseSixteen" class="collapse" aria-labelledby="headingSixteen" data-parent="#accordionExample">
                    <div class="card-body">
                         <ol type="1">
                             <li>En la barra de navegación seleccionar la opción de "Cerrar sesión"</li>
                            <li>Se cierra sesión y se redirige a la página de inicio de sesión</li>
                        </ol>
                    </div>
                </div>
            </div>
            <div class="card">
                <div class="card-header" id="headingSeventeen">
                    <h5 class="mb-0">
                        <button class="btn btn-link collapsed" type="button" data-toggle="collapse" data-target="#collapseSeventeen" aria-expanded="false" aria-controls="collapseSeventeen">
                            Crear un nuevo usuario para el sistema
                        </button>
                    </h5>
                </div>
                <div id="collapseSeventeen" class="collapse" aria-labelledby="headingSeventeen" data-parent="#accordionExample">
                    <div class="card-body">
                         <ol type="1">
                             <li>Únicamente los usuarios con el rol de administrador pueden realizar esta acción</li>
                             <li>Iniciar sesión</li>
                            <li>Ir a la sección de "Administrador de Empleados"</li>
                            <li>Llenar los espacios del formulario</li>
                             <li>Dar click en guardar</li>
                        </ol>
                    </div>
                </div>
            </div>
            <div class="card">
                <div class="card-header" id="headingEighteen">
                    <h5 class="mb-0">
                        <button class="btn btn-link collapsed" type="button" data-toggle="collapse" data-target="#collapseEighteen" aria-expanded="false" aria-controls="collapseEighteen">
                            Habilitar/Deshabilitar un usuario del sistema
                        </button>
                    </h5>
                </div>
                <div id="collapseEighteen" class="collapse" aria-labelledby="headingEighteen" data-parent="#accordionExample">
                    <div class="card-body">
                         <ol type="1">
                             <li>Únicamente los usuarios con el rol de administrador pueden realizar esta acción</li>
                             <li>Iniciar sesión</li>
                            <li>Ir a la sección de "Empleados"</li>
                            <li>Dar click en el botón "Cambiar Estado" de la fila donde se encuentra el usuario que se desea cambiar el estado</li>
                             <li>El cambio se ve reflejado de manera automática en la tabla "Empleados"</li>
                        </ol>
                    </div>
                </div>
            </div>

        </div>

        <br />
        <br />



    </div>

</asp:Content>
