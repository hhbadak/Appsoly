<%@ Page Title="" Language="C#" MasterPageFile="~/index.Master" AutoEventWireup="true" CodeBehind="contact.aspx.cs" Inherits="Appsoly.contact" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Start  blog Section-->
    <section class="contact-us  mega-section  pb-0" id="contact-us">
        <div class="container">
            <section class="locations-section  mega-section ">
                <div class="sec-heading centered  ">
                    <div class="content-area">
                        <h2 class=" title    wow fadeInUp" data-wow-delay=".4s">Ofis</h2>
                    </div>
                </div>
                <div class="contact-info-panel ">
                    <div class="info-section ">
                        <div class="row">
                            <div class="col-12 col-lg-4 mx-auto mx-lg-0">
                                <div class="info-panel  wow fadeInUp" data-wow-delay=".6s">
                                    <h4 class="location-title">Eskişehir</h4>
                                    <div class="line-on-side "></div>
                                    <p class="location-address">Beraberlik Sokak No:30 Yenibağlar/Tepebaşı/Eskişehir</p>
                                    <div class="location-card  ">
                                        <i class="flaticon-email icon"></i>
                                        <div class="card-content">
                                            <h6 class="content-title">E-Mail:</h6>
                                            <a class="email link" href="mailto:info@appsoly.com">info@appsoly.com</a>
                                        </div>
                                    </div>
                                    <div class="location-card  ">
                                        <i class="flaticon-phone-call icon"></i>
                                        <div class="card-content">
                                            <h6 class="content-title">Telefon:</h6>
                                            <a class="tel link" href="tel:+905372596733">+90 537 259 6733</a>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </section>
        </div>
        <div class="container-fluid">
            <section class="map-section ">
                <div class="map-box  wow fadeInUp" data-wow-delay=".6s">
                    <div class="mapouter">
                        <div class="gmap_canvas">
                            <iframe class="map-iframe" id="gmap_canvas" src="https://www.google.com/maps/embed?pb=!1m23!1m12!1m3!1d3065.811172806252!2d30.508801875645485!3d39.78879279361896!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!4m8!3e6!4m5!1s0x14cc15ef50890625%3A0xf550440e6432fcd0!2zWWVuaWJhxJ9sYXIsIEJlcmFiZXJsaWsgU2suIE5vOjMwLCAyNjE3MCBUZXBlYmHFn8SxL0Vza2nFn2VoaXIsIFTDvHJraXll!3m2!1d39.7887887!2d30.511376799999997!4m0!5e0!3m2!1str!2str!4v1711802626414!5m2!1str!2str" loading="lazy"></iframe>
                        </div>
                    </div>
                </div>
            </section>
        </div>
    </section>
    <section class="contact-us-form-section  mega-section  ">
        <div class="row">
            <div class="col-12 ">
                <div class="contact-form-panel">
                    <div class="sec-heading centered    ">
                        <div class="content-area">
                            <h2 class=" title    wow fadeInUp" data-wow-delay=".4s">Sorunuz mu var? Cevaplayalım</h2>
                        </div>
                    </div>
                    <div class="contact-form-inputs wow fadeInUp" data-wow-delay=".6s">
                        <div class="custom-form-area input-boxed">
                            <!--Form To have user messages-->
                            <form class="main-form" id="contact-us-form" action="php/send-mail.php" method="post">
                                <span class="done-msg"></span>
                                <div class="row ">
                                    <div class="col-12 col-lg-6">
                                        <div class="   input-wrapper">
                                            <input class="text-input" id="user-name" name="UserName" type="text" />
                                            <label class="input-label" for="user-name">Adınız <span class="req">*</span></label><span class="b-border"></span><span class="error-msg"></span>
                                        </div>
                                    </div>
                                    <div class="col-12 col-lg-6">
                                        <div class="   input-wrapper">
                                            <input class="text-input" id="user-email" name="UserEmail" type="email" />
                                            <label class="input-label" for="user-email">E-mail <span class="req">*</span></label><span class="b-border"></span><span class="error-msg"></span>
                                        </div>
                                    </div>
                                    <div class="col-12 ">
                                        <div class="   input-wrapper">
                                            <input class="text-input" id="msg-subject" name="subject" type="text" />
                                            <label class="input-label" for="msg-subject">Konu <span class="req">*</span></label><span class="b-border"></span><span class="error-msg"></span>
                                        </div>
                                    </div>
                                    <div class="col-12 ">
                                        <div class="   input-wrapper">
                                            <textarea class=" text-input" id="msg-text" name="message"></textarea>
                                            <label class="input-label" for="msg-text">Mesajınız<span class="req">*</span></label><span class="b-border"></span><i></i><span class="error-msg"></span>
                                        </div>
                                    </div>
                                    <div class="col-12 submit-wrapper">
                                        <button class=" btn-solid" id="submit-btn" type="submit" name="UserSubmit">Mesaj Gönder</button>
                                    </div>
                                </div>
                            </form>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- End  blog Section-->
</asp:Content>
