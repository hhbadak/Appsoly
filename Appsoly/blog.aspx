<%@ Page Title="" Language="C#" MasterPageFile="~/index.Master" AutoEventWireup="true" CodeBehind="blog.aspx.cs" Inherits="Appsoly.blog" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Start  portfolio-slider Section-->
    <section class="portfolio portfolio-blocks mega-section" id="portfolio">
        <div class="container">
            <div class="sec-heading  ">
                <div class="content-area">
                    <span class=" pre-title       wow fadeInUp " data-wow-delay=".2s">portfolio</span>
                    <h2 class=" title    wow fadeInUp" data-wow-delay=".4s">Awesome <span class='hollow-text'>portfolio</span></h2>
                </div>
                <div class=" cta-area   wow fadeInUp" data-wow-delay=".8s"><a class="cta-btn btn-solid    " href="portfolio-grid.html">see more <i class="bi bi-arrow-right icon "></i></a></div>
            </div>
            <div class="portfolio-wrapper  ">
                <!--a menu of links to show the photos users needs   -->
                <ul class="portfolio-btn-list wow fadeInUp" data-wow-delay=".2s">
                    <li class="portfolio-btn active " data-filter="*">All</li>
                    <li class="portfolio-btn" data-filter=".mobile">mobile apps</li>
                    <li class="portfolio-btn" data-filter=".web">cloud</li>
                    <li class="portfolio-btn" data-filter=".data ">data analaysis </li>
                    <li class="portfolio-btn" data-filter=".hosting">hosting</li>
                </ul>
                <div class="portfolio-group wow fadeIn" data-wow-delay=".4s">
                    <div class="row ">
                        <div class="col-12  col-md-6  col-lg-4  portfolio-item mobile ">
                            <div class="item   ">
                                <a class="portfolio-img-link" href="assets/images/portfolio/1.jpg" data-fancybox=".show-in-fancybox">
                                    <img class="portfolio-img   img-fluid " loading="lazy" src="assets/images/portfolio/1.jpg" alt="portfolio item photo" /></a>
                                <div class="item-info ">
                                    <h3 class="item-title">mobile apps</h3>
                                    <i class="bi bi-eye icon "></i>
                                </div>
                            </div>
                        </div>
                        <div class="col-12  col-md-6  col-lg-4  portfolio-item web  ">
                            <div class="item   ">
                                <a class="portfolio-img-link" href="assets/images/portfolio/2.jpg" data-fancybox=".show-in-fancybox">
                                    <img class="portfolio-img   img-fluid " loading="lazy" src="assets/images/portfolio/2.jpg" alt="portfolio item photo" /></a>
                                <div class="item-info ">
                                    <h3 class="item-title">cloud</h3>
                                    <i class="bi bi-eye icon "></i>
                                </div>
                            </div>
                        </div>
                        <div class="col-12  col-md-6  col-lg-4  portfolio-item data ">
                            <div class="item   ">
                                <a class="portfolio-img-link" href="assets/images/portfolio/3.jpg" data-fancybox=".show-in-fancybox">
                                    <img class="portfolio-img   img-fluid " loading="lazy" src="assets/images/portfolio/3.jpg" alt="portfolio item photo" /></a>
                                <div class="item-info ">
                                    <h3 class="item-title">data analaysis</h3>
                                    <i class="bi bi-eye icon "></i>
                                </div>
                            </div>
                        </div>
                        <div class="col-12  col-md-6  col-lg-4  portfolio-item mobile ">
                            <div class="item   ">
                                <a class="portfolio-img-link" href="assets/images/portfolio/4.jpg" data-fancybox=".show-in-fancybox">
                                    <img class="portfolio-img   img-fluid " loading="lazy" src="assets/images/portfolio/4.jpg" alt="portfolio item photo" /></a>
                                <div class="item-info ">
                                    <h3 class="item-title">hosting</h3>
                                    <i class="bi bi-eye icon "></i>
                                </div>
                            </div>
                        </div>
                        <div class="col-12  col-md-6  col-lg-4  portfolio-item hosting ">
                            <div class="item   ">
                                <a class="portfolio-img-link" href="assets/images/portfolio/5.jpg" data-fancybox=".show-in-fancybox">
                                    <img class="portfolio-img   img-fluid " loading="lazy" src="assets/images/portfolio/5.jpg" alt="portfolio item photo" /></a>
                                <div class="item-info ">
                                    <h3 class="item-title">SEO</h3>
                                    <i class="bi bi-eye icon "></i>
                                </div>
                            </div>
                        </div>
                        <div class="col-12  col-md-6  col-lg-4  portfolio-item mobile">
                            <div class="item   ">
                                <a class="portfolio-img-link" href="assets/images/portfolio/6.jpg" data-fancybox=".show-in-fancybox">
                                    <img class="portfolio-img   img-fluid " loading="lazy" src="assets/images/portfolio/6.jpg" alt="portfolio item photo" /></a>
                                <div class="item-info ">
                                    <h3 class="item-title">other category</h3>
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
