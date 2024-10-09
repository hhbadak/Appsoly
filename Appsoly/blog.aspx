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
                    <li class="portfolio-btn" data-filter=".social">Sosyal Medya</li>
                    <li class="portfolio-btn" data-filter=".seo">SEO</li>
                    <li class="portfolio-btn" data-filter=".bt">Bilişim Sistemleri</li>
                    <li class="portfolio-btn" data-filter=".mobile">Mobil</li>
                </ul>
                <div class="portfolio-group wow fadeIn" data-wow-delay=".4s">
                    <div class="row ">
                        <div class="col-12  col-md-6  col-lg-4  portfolio-item software ">
                            <div class="posts-grid ">
                                <div class="row">
                                    <asp:Repeater ID="rp_blogSoftware" runat="server">
                                        <ItemTemplate>
                                            <div class="item   ">
                                                <div class="post-box">
                                                    <a class="post-link" href='blogDetail.aspx?mid=<%# Eval("ID") %>' title="<%# Eval("Title") %>">
                                                        <div class="post-img-wrapper">
                                                            <img height="277px;" width="416px;" class=" parallax-img post-img" loading="lazy" src="../assets/images/blog/imgThumb/<%# Eval("ImgThumb") %>" alt="" /><span class="post-date"><span class="day"><%# ((DateTime)Eval("Date")).ToString("dd.MM.yyyy") %></span></span>
                                                        </div>
                                                    </a>
                                                    <div class="post-summary" style="width: 100%">
                                                        <div class="post-info"><a class="info post-cat" href="#"><i class="bi bi-bookmark icon"></i><%# Eval("Service") %></a><a class="info post-author" href="#"> <i class=" bi bi-person icon"></i><%# Eval("Team") %></a></div>
                                                        <div class="post-text">
                                                            <a class="post-link" href='blogDetail.aspx?mid=<%# Eval("ID") %>'>
                                                                <h2 class="post-title"><%# Eval("Title") %></h2>
                                                            </a>
                                                            <p class="post-excerpt" style="opacity: .75;"><%# Eval("Brief") %></p>

                                                            <a class="read-more" title="<%# Eval("Title") %>" href='blogDetail.aspx?mid=<%# Eval("ID") %>'>Devamı...<i class="bi bi-arrow-right icon "></i></a>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </ItemTemplate>
                                    </asp:Repeater>
                                </div>
                            </div>
                        </div>
                        <div class="col-12  col-md-6  col-lg-4  portfolio-item social ">
                            <div class="posts-grid ">
                                <div class="row">
                                    <asp:Repeater ID="rp_blogSocial" runat="server">
                                        <ItemTemplate>
                                            <div class="item   ">
                                                <div class="post-box">
                                                    <a class="post-link" href='blogDetail.aspx?mid=<%# Eval("ID") %>' title="<%# Eval("Title") %>">
                                                        <div class="post-img-wrapper">
                                                            <img height="277px;" width="416px;" class=" parallax-img post-img" loading="lazy" src="../assets/images/blog/imgThumb/<%# Eval("ImgThumb") %>" alt="" /><span class="post-date"><span class="day"><%# ((DateTime)Eval("Date")).ToString("dd.MM.yyyy") %></span></span>
                                                        </div>
                                                    </a>
                                                    <div class="post-summary" style="width: 100%">
                                                        <div class="post-info"><a class="info post-cat" href="#"><i class="bi bi-bookmark icon"></i><%# Eval("Service") %></a><a class="info post-author" href="#"> <i class=" bi bi-person icon"></i><%# Eval("Team") %></a></div>
                                                        <div class="post-text">
                                                            <a class="post-link" href='blogDetail.aspx?mid=<%# Eval("ID") %>'>
                                                                <h2 class="post-title"><%# Eval("Title") %></h2>
                                                            </a>
                                                            <p class="post-excerpt" style="opacity: .75;"><%# Eval("Brief") %></p>

                                                            <a class="read-more" title="<%# Eval("Title") %>" href='blogDetail.aspx?mid=<%# Eval("ID") %>'>Devamı...<i class="bi bi-arrow-right icon "></i></a>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </ItemTemplate>
                                    </asp:Repeater>
                                </div>
                            </div>
                        </div>
                        <div class="col-12  col-md-6  col-lg-4  portfolio-item seo ">
                            <div class="posts-grid ">
                                <div class="row">
                                    <asp:Repeater ID="rp_blogSeo" runat="server">
                                        <ItemTemplate>
                                            <div class="item   ">
                                                <div class="post-box">
                                                    <a class="post-link" href='blogDetail.aspx?mid=<%# Eval("ID") %>' title="<%# Eval("Title") %>">
                                                        <div class="post-img-wrapper">
                                                            <img height="277px;" width="416px;" class=" parallax-img post-img" loading="lazy" src="../assets/images/blog/imgThumb/<%# Eval("ImgThumb") %>" alt="" /><span class="post-date"><span class="day"><%# ((DateTime)Eval("Date")).ToString("dd.MM.yyyy") %></span></span>
                                                        </div>
                                                    </a>
                                                    <div class="post-summary" style="width: 100%">
                                                        <div class="post-info"><a class="info post-cat" href="#"><i class="bi bi-bookmark icon"></i><%# Eval("Service") %></a><a class="info post-author" href="#"> <i class=" bi bi-person icon"></i><%# Eval("Team") %></a></div>
                                                        <div class="post-text">
                                                            <a class="post-link" href='blogDetail.aspx?mid=<%# Eval("ID") %>'>
                                                                <h2 class="post-title"><%# Eval("Title") %></h2>
                                                            </a>
                                                            <p class="post-excerpt" style="opacity: .75;"><%# Eval("Brief") %></p>

                                                            <a class="read-more" title="<%# Eval("Title") %>" href='blogDetail.aspx?mid=<%# Eval("ID") %>'>Devamı...<i class="bi bi-arrow-right icon "></i></a>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </ItemTemplate>
                                    </asp:Repeater>
                                </div>
                            </div>
                        </div>
                        <div class="col-12  col-md-6  col-lg-4  portfolio-item bt ">
                            <div class="posts-grid ">
                                <div class="row">
                                    <asp:Repeater ID="rp_blogBt" runat="server">
                                        <ItemTemplate>
                                            <div class="item   ">
                                                <div class="post-box">
                                                    <a class="post-link" href='blogDetail.aspx?mid=<%# Eval("ID") %>' title="<%# Eval("Title") %>">
                                                        <div class="post-img-wrapper">
                                                            <img height="277px;" width="416px;" class=" parallax-img post-img" loading="lazy" src="../assets/images/blog/imgThumb/<%# Eval("ImgThumb") %>" alt="" /><span class="post-date"><span class="day"><%# ((DateTime)Eval("Date")).ToString("dd.MM.yyyy") %></span></span>
                                                        </div>
                                                    </a>
                                                    <div class="post-summary" style="width: 100%">
                                                        <div class="post-info"><a class="info post-cat" href="#"><i class="bi bi-bookmark icon"></i><%# Eval("Service") %></a><a class="info post-author" href="#"> <i class=" bi bi-person icon"></i><%# Eval("Team") %></a></div>
                                                        <div class="post-text">
                                                            <a class="post-link" href='blogDetail.aspx?mid=<%# Eval("ID") %>'>
                                                                <h2 class="post-title"><%# Eval("Title") %></h2>
                                                            </a>
                                                            <p class="post-excerpt" style="opacity: .75;"><%# Eval("Brief") %></p>

                                                            <a class="read-more" title="<%# Eval("Title") %>" href='blogDetail.aspx?mid=<%# Eval("ID") %>'>Devamı...<i class="bi bi-arrow-right icon "></i></a>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </ItemTemplate>
                                    </asp:Repeater>
                                </div>
                            </div>
                        </div>
                        <div class="col-12  col-md-6  col-lg-4  portfolio-item mobile ">
                            <div class="posts-grid ">
                                <div class="row">
                                    <asp:Repeater ID="rp_blogMobile" runat="server">
                                        <ItemTemplate>
                                            <div class="item   ">
                                                <div class="post-box">
                                                    <a class="post-link" href='blogDetail.aspx?mid=<%# Eval("ID") %>' title="<%# Eval("Title") %>">
                                                        <div class="post-img-wrapper">
                                                            <img height="277px;" width="416px;" class=" parallax-img post-img" loading="lazy" src="../assets/images/blog/imgThumb/<%# Eval("ImgThumb") %>" alt="" /><span class="post-date"><span class="day"><%# ((DateTime)Eval("Date")).ToString("dd.MM.yyyy") %></span></span>
                                                        </div>
                                                    </a>
                                                    <div class="post-summary" style="width: 100%">
                                                        <div class="post-info"><a class="info post-cat" href="#"><i class="bi bi-bookmark icon"></i><%# Eval("Service") %></a><a class="info post-author" href="#"> <i class=" bi bi-person icon"></i><%# Eval("Team") %></a></div>
                                                        <div class="post-text">
                                                            <a class="post-link" href='blogDetail.aspx?mid=<%# Eval("ID") %>'>
                                                                <h2 class="post-title"><%# Eval("Title") %></h2>
                                                            </a>
                                                            <p class="post-excerpt" style="opacity: .75;"><%# Eval("Brief") %></p>

                                                            <a class="read-more" title="<%# Eval("Title") %>" href='blogDetail.aspx?mid=<%# Eval("ID") %>'>Devamı...<i class="bi bi-arrow-right icon "></i></a>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </ItemTemplate>
                                    </asp:Repeater>
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
