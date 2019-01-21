
"text/javascript" 
   $(document).ready(function(){
       $(function () {
           $('#updoc').change(function () {
               var val = $(this).val().toLowerCase(),
                   regex = new RegExp("(.*?)\.(pdf)$");

               if (!(regex.test(val))) {
                   $(this).val('');
                   alert('Please select correct file format');
               }
           });
       });
       $(function () {
           $('#pslips').change(function () {
               var val = $(this).val().toLowerCase(),
                   regex = new RegExp("(.*?)\.(pdf)$");

               if (!(regex.test(val))) {
                   $(this).val('');
                   alert('Please select correct file format');
               }
           });
       });
       $(function () {
           $('#image').change(function () {
               var val = $(this).val().toLowerCase(),
                   regex = new RegExp("(.*?)\.(png)$");

               if (!(regex.test(val))) {
                   $(this).val('');
                   alert('Please select correct file format');
               }
           });
       });

       $("#btn_apply").click( function() { 
           $("#form1").validate({  
               rules: {
                   //This section we need to place our custom rule for the control. 
                   <%=loansdropdown.UniqueID %>:{ 
                       required:true 
                   },
                   <%=lamount.UniqueID %>:{ 
                        
                       required:true 
                   },
                   <%=updoc.UniqueID %>:{ 
                        
                       required:true 
                   },
                   <%=Tfemployment.UniqueID %>:{ 
                        
                       required:true 
                   },
                   <%=Ipmonth.UniqueID %>:{ 
                        
                       required:true
                   },
                   <%=pslips.UniqueID %>:{ 
                       required: true
                   },
                   <%=image.UniqueID %>:{ 
                       required: true,
                   }
               },
            
               messages: {
                   //This section we need to place our custom validation message for each control.  
                   <%=loansdropdown.UniqueID %>:{  
                       required: "Please select a loan."  
                        
                   }, 
                   <%=lamount.UniqueID %>:{  
                       required: "Please enter Loan Amount."  ,
                   }, 
                   <%=updoc.UniqueID %>:{  
                       required: "Please select a file to Uploaded."  
                        
                   },
                   <%=Tfemployment.UniqueID %>:{  
                       required: "Please select a employee."  
                        
                   }, 
                   <%=Ipmonth.UniqueID %>:{  
                       required: "Please enter Income" ,
                        
                   }, 

                   <%=pslips.UniqueID %>:{  
                       required: "Please select a file to Uploaded."  
                        
                   }, 
                   <%=image.UniqueID %>:{  
                       required: "Please select a file to Uploaded."  
                   }
               }

            
           });
       });
   });