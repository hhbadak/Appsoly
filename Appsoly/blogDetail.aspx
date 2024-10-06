﻿<%@ Page Title="" Language="C#" MasterPageFile="~/index.Master" AutoEventWireup="true" CodeBehind="blogDetail.aspx.cs" Inherits="Appsoly.blogDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="blog blog-post">
        <div class="container">
            <div class="row">
                <div class="col-12 col-lg-10 mx-auto">
                    <div class="social">
                        <div class="share-us ">
                            <h6 class="share-title">Share post:</h6>
                            <div class="sc-wrapper dir-row sc-flat">
                                <ul class="sc-list">
                                    <li class="sc-item ">
                                        <a class="sc-link" href="#0" title="social media icon"><i class="fab fa-facebook-f sc-icon"></i></a>
                                    </li>
                                    <li class="sc-item ">
                                        <a class="sc-link" href="#0" title="social media icon"><i class="fab fa-facebook-f sc-icon"></i></a>
                                    </li>
                                    <li class="sc-item ">
                                        <a class="sc-link" href="#0" title="social media icon"><i class="fab fa-facebook-f sc-icon"></i></a>
                                    </li>
                                    <li class="sc-item ">
                                        <a class="sc-link" href="#0" title="social media icon"><i class="fab fa-facebook-f sc-icon"></i></a>
                                    </li>
                                </ul>
                            </div>
                        </div>
                    </div>

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
                        <div class="author-profile panel">
                            <h6 class="panel-title">about author</h6>
                            <div class="author-info">
                                <div class="author-avatar">
                                    <a class="author-link" href="#">
                                        <img class="avatar-img" loading="lazy" src="assets/images/blog/avatars/1.jpg" alt="Alternate Text" />
                                    </a>
                                </div>
                                <div class="author-disc">
                                    <h6 class="author-name"></h6>
                                    <a class="author-link" href="#">mohamed amin</a>
                                    <p class="author-bio">
                                        Lorem ipsum dolor sit amet consectetur adipisicing elit.
                      Rerum ex nulla magnam aliquam atque perspiciatis eos consequuntur aspernatur tempore, 
                      quasi ullam officiis modi nostrum molestiae ipsa mollitia excepturi sequi inventore.
                                    </p>
                                    <div class="sc-wrapper dir-row sc-size-32">
                                        <ul class="sc-list">
                                            <li class="sc-item" title="facebook">
                                                <a class="sc-link" href="#"><i class="fab fa-facebook-f sc-icon"></i></a>
                                            </li>
                                            <li class="sc-item" title="facebook">
                                                <a class="sc-link" href="#"><i class="fab fa-facebook-f sc-icon"></i></a>
                                            </li>
                                            <li class="sc-item" title="facebook">
                                                <a class="sc-link" href="#"><i class="fab fa-facebook-f sc-icon"></i></a>
                                            </li>
                                            <li class="sc-item" title="facebook">
                                                <a class="sc-link" href="#"><i class="fab fa-facebook-f sc-icon"></i></a>
                                            </li>
                                            <li class="sc-item" title="facebook">
                                                <a class="sc-link" href="#"><i class="fab fa-facebook-f sc-icon"></i></a>
                                            </li>
                                        </ul>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="other-posts panel">
                            <h6 class="panel-title">posts by the author</h6>
                            <div class="row">
                                <div class="col-12 col-sm-6 mb-3">
                                    <div class="prev-post">
                                        <a class="other-post-link" href="#">
                                            <div class="other-post-img" title="Previous Post">
                                                <img class="img-fluid" loading="lazy" src="assets/images/blog/post-images/1.jpg" alt="Alternate Text" />
                                                <i class="bi bi-chevron-left icon "></i>
                                            </div>
                                            <h6 class="other-post-title">how to get early saves your day and give you the productivity you want
                                            </h6>
                                        </a>
                                    </div>
                                </div>
                                <div class="col-12 col-sm-6">
                                    <div class="next-post">
                                        <a class="other-post-link" href="#">
                                            <div class="other-post-img" title="next post">
                                                <img class="img-fluid" loading="lazy" src="assets/images/blog/post-images/2.jpg" alt="Alternate Text" />
                                                <i class="bi bi-chevron-right icon "></i>
                                            </div>
                                            <h6 class="other-post-title">9 Habits Make You A Better Person, No. 3 Will Surprise You</h6>
                                        </a>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="col-12 col-lg-8">
                            <div class="comments-area panel">
                                <h6 class="panel-title">comments</h6>
                                <div class="comment-wrapper ">
                                    <div class="author-avatar">
                                        <a class="comment-author-link" href="#">
                                            <img class="author-avatar-img" loading="lazy" src="assets/images/blog/avatars/2.jpg" alt="Alternate Text" />
                                        </a>
                                    </div>
                                    <div class="comment-body">
                                        <div class="comment-author">
                                            <a class="comment-author-link" href="#">aamed</a>
                                        </div>
                                        <div class="comment-date">
                                            <a class="date-link" href="#">
                                                <time datetime="2022-08-25T17:17:33+00:00">Aug 25, 2022 at 5:17 pm </time>
                                            </a>
                                        </div>
                                        <div class="comment-content">
                                            <p class="comment-text">
                                                Lorem ipsum dolor, sit amet consectetur
                          adipisicing elit.Odit iure magni
                          quidem debitis ut tempore eaque quod fugiat? Quidem, aperiam.
                          
                                            </p>
                                        </div>
                                        <div class="reply-action">
                                            <a class="reply-link" href="#" rel="nofollow">reply <i class="fas fa-share-square icon"></i></a>
                                        </div>
                                    </div>
                                </div>
                                <div class="comment-wrapper comment-reply ">
                                    <div class="author-avatar">
                                        <a class="comment-author-link" href="#">
                                            <img class="author-avatar-img" loading="lazy" src="#" alt="Alternate Text" />
                                        </a>
                                    </div>
                                    <div class="comment-body">
                                        <div class="comment-author">
                                            <a class="comment-author-link" href="#">moamed amin</a>
                                        </div>
                                        <div class="comment-date">
                                            <a class="date-link" href="#">
                                                <time datetime="2022-08-21T17:17:33+00:00">Nov 21, 2022 at 5:17 pm </time>
                                            </a>
                                        </div>
                                        <div class="comment-content">
                                            <p class="comment-text">
                                                Lorem ipsum dolor, sit amet consectetur
                          adipisicing elit.Odit iure magni
                          quidem debitis ut tempore eaque quod fugiat? Quidem, aperiam.
                                            </p>
                                        </div>
                                        <div class="reply-action">
                                            <a class="reply-link" href="#" rel="nofollow">reply <i class="fas fa-share-square icon"></i></a>
                                        </div>
                                    </div>
                                </div>
                                <div class="comment-wrapper ">
                                    <div class="author-avatar">
                                        <a class="comment-author-link" href="#">
                                            <img class="author-avatar-img" loading="lazy" src="assets/images/blog/avatars/3.jpg" alt="Alternate Text" />
                                        </a>
                                    </div>
                                    <div class="comment-body">
                                        <div class="comment-author">
                                            <a class="comment-author-link" href="#">fairouz amin</a>
                                        </div>
                                        <div class="comment-date">
                                            <a class="date-link" href="#">
                                                <time datetime="2022-09-21T17:17:33+00:00">Oct 15, 2022 at 5:17 pm </time>
                                            </a>
                                        </div>
                                        <div class="comment-content">
                                            <p class="comment-text">
                                                Lorem ipsum dolor, sit amet consectetur
                          adipisicing elit.Odit iure magni
                          quidem debitis ut tempore eaque quod fugiat? Quidem, aperiam.
                          
                                            </p>
                                        </div>
                                        <div class="reply-action">
                                            <a class="reply-link" href="#" rel="nofollow">reply <i class="fas fa-share-square icon"></i></a>
                                        </div>
                                    </div>
                                </div>
                                <div class="comment-wrapper comment-reply ">
                                    <div class="author-avatar">
                                        <a class="comment-author-link" href="#">
                                            <img class="author-avatar-img" loading="lazy" src="assets/images/blog/avatars/4.jpg" alt="Alternate Text" />
                                        </a>
                                    </div>
                                    <div class="comment-body">
                                        <div class="comment-author">
                                            <a class="comment-author-link" href="#">dona summer</a>
                                        </div>
                                        <div class="comment-date">
                                            <a class="date-link" href="#">
                                                <time datetime="2019-09-21T17:17:33+00:00">Dec 21, 2019 at 5:17 pm </time>
                                            </a>
                                        </div>
                                        <div class="comment-content">
                                            <p class="comment-text">
                                                Lorem ipsum dolor, sit amet consectetur
                          adipisicing elit.Odit iure magni
                          quidem debitis ut tempore eaque quod fugiat? Quidem, aperiam.
                                            </p>
                                        </div>
                                        <div class="reply-action">
                                            <a class="reply-link" href="#" rel="nofollow">reply <i class="fas fa-share-square icon"></i></a>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="panel">
                                <h6 class="panel-title">leave your comment</h6>
                                <div class="custom-form-area input-boxed">
                                    <div class="row">
                                        <div class="col-12 col-lg-6   ">
                                            <div class="input-wrapper">
                                                <input class="text-input" id="userName" name="UserName" type="text" value="" placeholder />
                                                <label class="input-label">
                                                    Name
                                                <span class="req">*</span></label>
                                                <span class="b-border"></span>
                                                <span class="error-msg"></span>
                                            </div>
                                        </div>
                                        <div class="col-12 col-lg-6   ">
                                            <div class="input-wrapper">
                                                <input class="text-input" type="email" id="userMail" name="UserMail" value="" placeholder />
                                                <label class="input-label" for="userMail">E-mail <span class="req">*</span></label>
                                                <span class="b-border"></span>
                                                <span class="error-msg"></span>
                                            </div>
                                        </div>
                                        <div class="col-12">
                                            <div class="input-wrapper">
                                                <textarea class="text-input" id="msg-text" name="replyMessage"></textarea>
                                                <label class="input-label" for="msg-text">your comment <span class="req">*</span></label>
                                                <span class="b-border"></span>
                                                <i></i>
                                                <span class="error-msg"></span>
                                            </div>
                                        </div>
                                        <div class="col-12 submit-wrapper">
                                            <button class="btn-solid" id="submit-btn" type="submit" name="UserSubmit">Add comment</button>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
