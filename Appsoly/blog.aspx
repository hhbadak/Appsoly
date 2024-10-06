<%@ Page Title="" Language="C#" MasterPageFile="~/index.Master" AutoEventWireup="true" CodeBehind="blog.aspx.cs" Inherits="Appsoly.blog" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Start  portfolio-slider Section-->
    <section class="portfolio portfolio-blocks mega-section" id="portfolio">
        <div class="container">
            <div class="sec-heading  ">
                <div class="content-area">
                    <span class="pre-title wow fadeInUp " data-wow-delay=".2s">Blog</span>
                </div>
               
            </div>
            <div class="portfolio-wrapper  ">
                <!--a menu of links to show the photos users needs   -->
                <ul class="portfolio-btn-list wow fadeInUp" data-wow-delay=".2s">
                    <li class="portfolio-btn active " data-filter="*">Hepsi</li>
                    <li class="portfolio-btn" data-filter=".software">Yazılım</li>
                    <li class="portfolio-btn" data-filter=".3d">3D Yazıcı</li>
                </ul>
                <div class="portfolio-group wow fadeIn" data-wow-delay=".4s">
                    <div class="row ">
                        <div class="col-12  col-md-6  col-lg-4  portfolio-item software ">
                            <div class="item   ">
                                <a class="portfolio-img-link" href="assets/images/portfolio/5.jpg" data-fancybox=".show-in-fancybox">
                                    <img class="portfolio-img   img-fluid " loading="lazy" src="assets/images/portfolio/5.jpg" alt="portfolio item photo" /></a>
                                <div class="item-info ">
                                    <h3 class="item-title">Yazılım</h3>
                                    <i class="bi bi-eye icon "></i>
                                </div>
                            </div>
                        </div>
                        <div class="col-12  col-md-6  col-lg-4  portfolio-item 3d">
                            <div class="item   ">
                                <a class="portfolio-img-link" href="assets/images/portfolio/3D.jpg" data-fancybox=".show-in-fancybox">
                                    <img class="portfolio-img   img-fluid " loading="lazy" src="assets/images/portfolio/3D.jpg" alt="portfolio item photo" /></a>
                                <div class="item-info ">
                                    <h3 class="item-title">3D Yazıcı</h3>
                                    <i class="bi bi-eye icon "></i>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- End  portfolio-slider Section-->
</asp:Content>
