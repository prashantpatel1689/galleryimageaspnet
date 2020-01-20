<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="Gallery.aspx.cs" Inherits="Gallery" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder3" runat="Server">
    <script src="js gallery/jquery-1.6.1.min.js" type="text/javascript"></script>
    <link rel="stylesheet" href="css gallery/prettyPhoto.css" type="text/css" media="screen"
        title="prettyPhoto main stylesheet" charset="utf-8" />
    <script src="js gallery/jquery.prettyPhoto.js" type="text/javascript" charset="utf-8"></script>
    <style type="text/css" media="screen">
        *
        {
            margin: 0;
            padding: 0;
        }

      ul li
        {
            display: inline;
            list-style-type: none;
        }
       
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <img src="banner/photo-gallery.jpg" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <div class="wrapper">
        <table width="100%">
            <tr>
                <td width="98%">
                    <div class="pad_left1">
                        <h2 style="font-size: 18px; color: Black;">
                            GUEST GALLERY</h2>
                    </div>
                    <div class="wrapper pad_bot2"  >
                        <div id="DivTest">
                        </div>
                        <div id="main" align="center">
                            <ul class="gallery clearfix">
                            </ul>
                            <ul class="gallery clearfix" id="GalleryUL" runat="server">
                            </ul>
                            <script type="text/javascript" charset="utf-8">
                                $(document).ready(function () {
                                    $("area[rel^='prettyPhoto']").prettyPhoto();

                                    //$(".gallery:first a[rel^='prettyPhoto']").prettyPhoto({ animation_speed: 'normal', theme: 'light_square', slideshow: 3000, autoplay_slideshow: true });
                                    $(".gallery:gt(0) a[rel^='prettyPhoto']").prettyPhoto({ animation_speed: 'fast', slideshow: 10000, hideflash: true });

                                    $("#custom_content a[rel^='prettyPhoto']:first").prettyPhoto({
                                        custom_markup: '<div id="map_canvas" style="width:260px; height:265px"></div>',
                                        changepicturecallback: function () { initialize(); }
                                    });

                                    $("#custom_content a[rel^='prettyPhoto']:last").prettyPhoto({
                                        custom_markup: '<div id="bsap_1259344" class="bsarocks bsap_d49a0984d0f377271ccbf01a33f2b6d6"></div><div id="bsap_1237859" class="bsarocks bsap_d49a0984d0f377271ccbf01a33f2b6d6" style="height:260px"></div><div id="bsap_1251710" class="bsarocks bsap_d49a0984d0f377271ccbf01a33f2b6d6"></div>',
                                        changepicturecallback: function () { _bsap.exec(); }
                                    });
                                });
			</script>
                        </div>
                    </div>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
