<%@ Page Title="" Language="C#" MasterPageFile="~/index.Master" AutoEventWireup="true" CodeBehind="blogDetail.aspx.cs" Inherits="Appsoly.blogDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="blog blog-post">
        <div class="container">
            <div class="row">
                <div class="col-12 col-lg-10 mx-auto">
                    <asp:Repeater ID="rp_blogDetail" runat="server">
                        <ItemTemplate>

                            <h2 class="post-title"><%# Eval("Title") %></h2>
                            </div>
                <div class="col-12 col-lg-9 mx-auto">
                    <div class="post-main-area">
                        <div class="post-info">
                            <a class="info post-cat" href="#"><i class="fas fa-list-alt icon"></i><%# Eval("Service") %></a>
                            <a class="info post-author" href="#"><i class="fas fa-user icon"></i><%# Eval("Team") %></a><a class="info post-date"><i class="fas fa-history icon"></i></a><%# ((DateTime)Eval("Date")).ToString("dd.MM.yyyy") %>  <a class="info post-comments-count"><i class="fas fa-comments icon"></i><%# Eval("CommentCount") %></a>
                        </div>
                        <div class="post-content">
                            <p class=" first-litter post-text">
                                <%# Eval("Brief") %>
                            </p>
                            <h2 class="post-heading"><%# Eval("Title") %></h2>
                            <div class="post-img-wrapper">
                                <img loading="lazy" src="../assets/images/blog/images/<%# Eval("Image1") %>" alt="<%# Eval("Image1") %>" />
                            </div>
                            <p class="post-text">
                                <%# Eval("Contents1") %>
                            </p>

                            <p class="post-text">
                                <%# Eval("Contents2") %>
                            </p>
                            <div class="post-img-wrapper">
                                <img loading="lazy" src="../assets/images/blog/images/<%# Eval("Image2") %>" alt="<%# Eval("Image2") %>" />
                            </div>
                            <blockquote cite="#">
                                <i class="fas fa-quote-right icon"></i><span class="post-quote"><%# Eval("ImportantInformation") %></span>
                            </blockquote>
                            <p class="post-text">
                                <%# Eval("Content2Continued") %>
                            </p>
                        </div>
                        <div class="tags panel">
                            <ul class="sidebar-list tags-list ">
                                <li class="tags-icon-label "><i class="fas fa-tags icon"></i></li>
                                <li class="tag-item">
                                    <a class="tag-link" href="<%# Eval("Weld") %>"><%# Eval("Weld") %></a>
                                </li>
                            </ul>
                        </div>
                        </ItemTemplate>
                    </asp:Repeater>
                    <div class="col-12 col-lg-8">
                        <div id="notification" style="display: none; background-color: #d4edda; color: #155724; padding: 10px; margin-bottom: 15px; border: 1px solid #c3e6cb;">
                            Yorum Ekleme Başarılı
                        </div>
                        <div class="comments-area panel">
                            <h6 class="panel-title">Yorumlar</h6>
                            <asp:Repeater ID="rp_comment" runat="server">
                                <ItemTemplate>

                                    <div class="comment-wrapper ">
                                        <div class="author-avatar">
                                            <a class="logo-link" href="#">
                                                <img class="author-avatar-img" loading="lazy" src="../assets/images/blog/user.svg" alt="appsoly" />
                                            </a>
                                        </div>
                                        <div class="comment-body">
                                            <div class="comment-author">
                                                <a class="comment-author-link" href="#"><%# Eval("Name") %></a>
                                            </div>
                                            <div class="comment-date">
                                                <a class="date-link" href="#">
                                                    <time datetime="<%# ((DateTime)Eval("Date")).ToString("dd.MM.yyyy") %>"><%# ((DateTime)Eval("Date")).ToString("dd.MM.yyyy") %> </time>
                                                </a>
                                            </div>
                                            <div class="comment-content">
                                                <p class="comment-text">
                                                    <%# Eval("Comment") %>
                                                </p>
                                            </div>
                                        </div>
                                    </div>
                                </ItemTemplate>
                            </asp:Repeater>
                        </div>
                        <div class="panel">
                            <h6 class="panel-title" id="commentss" runat="server">Yorumunuzu bizimle paylaşın!</h6>
                            <div class="custom-form-area input-boxed">
                                <div class="row">
                                    <div class="col-12 col-lg-6   ">
                                        <div class="input-wrapper">
                                            <asp:TextBox CssClass="text-input" ID="tb_name" runat="server"></asp:TextBox>
                                            <label class="input-label">
                                                Adınız
                                                <span class="req">*</span></label>
                                            <span class="b-border"></span>
                                            <span class="error-msg"></span>
                                        </div>
                                    </div>
                                    <div class="col-12 col-lg-6   ">
                                        <div class="input-wrapper">
                                            <asp:TextBox CssClass="text-input" type="email" ID="tb_mail" runat="server" onblur="validateEmail(this)"></asp:TextBox>
                                            <span id="emailError" style="color: red; display: none;">Lütfen geçerli bir mail adresi giriniz</span>
                                            <label class="input-label" for="userMail">E-mail <span class="req">*</span></label>
                                            <span class="b-border"></span>
                                            <span class="error-msg"></span>
                                        </div>
                                    </div>
                                    <div class="col-12">
                                        <div class="input-wrapper">
                                            <asp:TextBox CssClass="text-input" ID="tb_comment" runat="server" TextMode="MultiLine" Rows="5" Columns="40"></asp:TextBox>

                                            <label class="input-label" for="msg-text">your comment <span class="req">*</span></label>
                                            <span class="b-border"></span>
                                            <i></i>
                                            <span class="error-msg"></span>
                                        </div>
                                    </div>
                                    <div class="col-12 submit-wrapper">
                                        <asp:LinkButton ID="lbtn_submit" runat="server" CssClass="btn-solid" OnClick="lbtn_submit_Click">Yorum Ekle</asp:LinkButton>
                                    </div>
                                </div>
                            </div>
                        </div>


                    </div>
                </div>
            </div>
        </div>
    </div>
    <script type="text/javascript">
        function validateEmail(emailField) {
            var email = emailField.value;
            var emailError = document.getElementById("emailError");

            // E-mail doğrulama için basit bir regex
            var regex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;

            // Eğer regex ile uyuşmazsa hata göster
            if (!regex.test(email)) {
                emailError.style.display = "inline";
                emailField.focus();
            } else {
                emailError.style.display = "none";
            }
        }
        window.onload = function () {
            // Burada scriptlerinizi yazabilirsiniz
        };
    </script>
</asp:Content>
