<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="products.aspx.cs" Inherits="WEB_NET_Aplication.models.products" enableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<form runat=server>
 <main>
    <div class="container-fluid">

      <!-- Section: Inputs -->
      <section class="section card mb-4">
        <div class="card text-center">
          <h3 class="card-header blue white-text">Productos</h3>
        </div>
          
           <asp:Panel runat="server" id="table"  class="card-body col-md-12" UpdateMode="Conditional"></asp:Panel>
      </section>
      <section>
         <div class="modal fade" id="modal_edit" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true" style="display: none;">
          <div class="modal-dialog modal-lg" role="document">
            <!-- Content -->
            <div class="modal-content">
              <div class="modal-c-tabs">
                  <div class="tab-pane fade in show active mt-4 ml-4">
                      <h4><strong>Modificar Producto</strong></h4>
                    <div class="modal-body mb-1">
                                  
              <div class="row">
                <div class="col-md-4 mb-4">
                  <div class="md-form">
                      <asp:TextBox id="txt_nombre" runat="server" class="form-control" type="text" ></asp:TextBox>
                    <label for="form1" class="">Nombre</label>
                  </div>
                </div>
                <div class="col-md-4 mb-4">
                  <div class="md-form">
                      <asp:TextBox id="txt_price" runat="server" class="form-control" type="number" ></asp:TextBox>

                    <label for="form1" class="">Precio</label>
                  </div>
                </div>
                <div class="col-md-4 mb-4">
                  <div class="md-form">
                      <asp:TextBox id="txt_rate" runat="server" class="form-control" type="number" ></asp:TextBox>
                    <label for="form1" class="">Calificacion</label>
                  </div>
                </div>
              </div>
              <div class="row">
                <div class="col-lg-6 col-md-6 mb-4">
                    <asp:DropDownList runat="server" class="mdb-select md-form" id="dd_type"></asp:DropDownList>
                </div>
                <div class="col-lg-6 col-md-6">
                    <asp:DropDownList runat="server" class="mdb-select md-form" id="dd_color"></asp:DropDownList>
                </div>
              </div>
              <div class="row text-left">
                <div class="col-md-12">
                  <div class="md-form">
                      <asp:TextBox id="txt_description" runat="server" class="md-textarea form-control" type="text" rows="2"></asp:TextBox>

                    <label for="form10">Descripcion</label>
                  </div>
                </div>
              </div>
              <div class="row">
                <div class="col-md-12 mb-6">
                  <form>
                    <div class="md-form">
                      <div class="file-field">
                        <div class="row">
                            <asp:Button runat="server" class="btn btn-light-green btn-sm float-left" text="Selecionar Imagen" id="btn_uploadimg"/>
                            <asp:FileUpload runat="server" id="file_img"></asp:FileUpload>
                        </div>
                      </div>
                    </div>
                  </form>
                </div>
              </div>
              <hr></hr>
              <div class="col-lg-12 col-md-12 mb-12">
                <div class="card-foter text-right">
                    
                </div>
              </div>


                    </div>
                    <!-- Footer -->
                    <div class="modal-footer">
                      <div class="options text-center text-md-right mt-1">
                          <button type="button" class="btn btn-light-green waves-effect ml-auto" data-dismiss="modal" onClick ="Modify()">Modificar</button>
                          <button type="button" class="btn btn-secondary waves-effect ml-auto" data-dismiss="modal">Cancelar</button>
                    </div>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </section>
       <section>
         <div class="modal fade" id="modal_delete" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true" style="display: none;">
          <div class="modal-dialog cascading-modal" role="document">
            <!-- Content -->
            <div class="modal-content">
              <div class="modal-c-tabs">
                  <div class="tab-pane fade in show active">

                    <div class="modal-body mb-1">
                      <div class="md-form form-sm">
                          <h4>Desea eliminar producto?</h4>
                       <button type="button" class="btn btn-light-green waves-effect ml-auto" data-dismiss="modal" onclick ="Delete()">Eliminar</button>
                       <button type="button" class="btn btn-secondary waves-effect ml-auto" data-dismiss="modal">Cancelar</button>
                      </div>
                    </div>
                  </div>
              </div>
            </div>
          </div>
        </div>
      </section>

    </div>
     <asp:Button  runat="server" OnClick="Delete" id="btn_delete" style="display:none"/>
    <asp:Button  runat="server" OnClick="Modify" id="btn_modify" style="display:none"/>
    <asp:Button  runat="server" OnClick="View" id="btn_view" style="display:none"/>

    <asp:TextBox id="viewid" runat="server" type="text" value="" style="display:none"></asp:TextBox>
  </main>
    
</form>
           
    <script>
        function View(id) {
            console.log(parseInt($(id).text()));
            document.getElementById("head_viewid").setAttribute("value", parseInt($(id).text()));
            $("#head_btn_view").click();
        }

        function Delete() {
            $("#head_btn_delete").click();
        }
        function Modify() {
            $("#head_btn_modify").click();
        }
    </script>
</asp:Content>
