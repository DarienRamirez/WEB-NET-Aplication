<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="color_register.aspx.cs" Inherits="WEB_NET_Aplication.color_register" enableEventValidation="false"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <form runat=server>
        <main>
            <div class="container-fluid">

          <!-- Section: Inputs -->
          <section class="section card mb-5">
            <div class="card text-center">
              <h3 class="card-header cyan white-text">Registro de Colores</h3>
            <div class="card-body">
              <div class="row">
                <div class="col-md-12 mb-8">
                  <div class="md-form">
                      <asp:TextBox id="txt_nombre" runat="server" class="form-control" type="text" required></asp:TextBox>
                    <label for="form1" class="">Nombre</label>
                  </div>
                </div>
                                <div class="col-lg-12 col-md-12 mb-12">
                <div class="text-right">
                    <asp:Button runat="server" Text="Registrar" class="btn btn-light-green waves-effect waves-light" style="width: 140px;" OnClick="Register"/>
                     
                </div>
              </div>
              </div>
                <div class="row">
                    <div class="col-lg-12">
                        <asp:Panel runat="server" id="table"></asp:Panel>
                    </div>
                </div>
            </div>
          </div>
          </section>
        </div>

       </main>

       <main>
        <section>
         <div class="modal fade" id="modal_edit" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true" style="display: none;">
          <div class="modal-dialog cascading-modal" role="document">
            <!-- Content -->
            <div class="modal-content">
              <div class="modal-c-tabs">
                  <div class="tab-pane fade in show active mt-4 ml-4">
                      <h4><strong>Modificar Color</strong></h4>
                    <div class="modal-body mb-1">
                      <div class="md-form form-sm">
                        <asp:TextBox id="txt_modify" runat="server" class="form-control form-control-sm" type="text" value=""></asp:TextBox>

                        <label for="form2">Color</label>
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
    </main>
       <main>
        <section>
         <div class="modal fade" id="modal_view" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true" style="display: none;">
          <div class="modal-dialog cascading-modal" role="document">
            <!-- Content -->
            <div class="modal-content">
              <div class="modal-c-tabs">
                  <div class="tab-pane fade in show active mt-4 ml-4">
                      <h4><strong>Informacion de Color</strong></h4>
                    <div class="modal-body mb-1">
                      <div class="md-form form-sm">
                        
                        <asp:TextBox id="txt_view" runat="server" class="form-control form-control-sm" type="text" value="" ></asp:TextBox>

                        <label for="form2">Color</label>
                      </div>
                    </div>
                    <!-- Footer -->
                    <div class="modal-footer">
                      <div class="options text-center text-md-right mt-1">
                          
                          <button type="button" class="btn btn-light-green waves-effect ml-auto" data-dismiss="modal">Aceptar</button>
                          <button type="button" class="btn btn-secondary waves-effect ml-auto" data-dismiss="modal">Cancelar</button>
                    </div>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </section>
    </main>
     <main>
        <section>
         <div class="modal fade" id="modal_delete" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true" style="display: none;">
          <div class="modal-dialog cascading-modal" role="document">
            <!-- Content -->
            <div class="modal-content">
              <div class="modal-c-tabs">
                  <div class="tab-pane fade in show active">

                    <div class="modal-body mb-1">
                      <div class="md-form form-sm">
                          <h4>Desea eliminar color?</h4>
                       <button type="button" class="btn btn-light-green waves-effect ml-auto" data-dismiss="modal" onClick ="Delete()">Eliminar</button>
                       <button type="button" class="btn btn-secondary waves-effect ml-auto" data-dismiss="modal">Cancelar</button>
                      </div>
                    </div>
                  </div>
              </div>
            </div>
          </div>
        </div>
      </section>
         <asp:Button  runat="server" OnClick="Delete" id="btn_delete" style="display:none"/>
         <asp:Button  runat="server" OnClick="Modify" id="btn_modify" style="display:none"/>
         <asp:Button  runat="server" OnClick="View" id="btn_view" style="display:none"/>


         <asp:TextBox id="deleteid" runat="server" class="form-control" type="text" value="" style="display:none"></asp:TextBox>
         
    </main>
    </form>
    <script>
        function View(id,state) {
            console.log($(id).text());
            document.getElementById("head_deleteid").setAttribute("value", $(id).text());
            //$("#head_btn_view").click();

        }
        function Delete() {
            $("#head_btn_delete").click();
        }
        function Modify() {
            $("#head_btn_modify").click();
        }
    </script>
</asp:Content>
