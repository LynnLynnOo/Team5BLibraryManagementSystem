//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Team5BLibraryManagementSystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class Booksdetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Booksdetail()
        {
            this.Books = new HashSet<Book>();
        }
    
        public int booksdetailsid { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public string publisher { get; set; }
        public decimal publishyear { get; set; }
        public string category { get; set; }
        public string isbn { get; set; }
        public int quantity { get; set; }
        public string location { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Book> Books { get; set; }
    }
}
