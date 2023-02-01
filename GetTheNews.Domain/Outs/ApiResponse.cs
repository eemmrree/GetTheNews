using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetTheNews.Domain.Outs
{
    public class ApiResponse<T>
    {
        /// <summary>
        /// Gets or sets the Code
        /// Başarısız işlemler için hata kodu. Başarılı işlemlerde 0
        /// </summary>
        public int Code { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether Ok
        /// True ise işlem başarılıdır.
        /// </summary>
        public bool Ok { get; set; }

        /// <summary>
        /// Gets or sets the Id
        /// İşlem yapılan kaydın Id değeri
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Gets or sets the Page
        /// Sayfa numarası
        /// </summary>
        public int Page { get; set; }

        /// <summary>
        /// Gets or sets the PageSize
        /// Sayfada gönderilecek kayıt sayısı
        /// </summary>
        public int PageSize { get; set; }

        /// <summary>
        /// Gets or sets the TotalPages
        /// Toplam sayfa sayısı
        /// </summary>
        public int? TotalPages { get; set; }

        /// <summary>
        /// Gets or sets the TotalCount
        /// Toplam kayıt sayısı
        /// </summary>
        public int? TotalCount { get; set; }

        /// <summary>
        /// Gets or sets the HasNext
        /// Sonraki soyfa kontrolü
        /// </summary>
        public bool? HasNext { get; set; }

        /// <summary>
        /// Gets or sets the HasPrevious
        /// Önceki sayfa kontrolü
        /// </summary>
        public bool? HasPrevious { get; set; }

        /// <summary>
        /// Gets or sets the Message
        /// İşlem açıklaması.
        /// Başarısız veya uyarı olan işlemlerde hata veya uyarı mesajını barındırır.
        /// Başarılı işlemlerde genellikle null değerini alır.
        /// </summary>
        public string Message { get; set; }


        /// <summary>
        /// Gets or sets the Data
        /// Gönderilen datalar
        /// </summary>
        public T Data { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponse"/> class.
        /// </summary>
        /// <param name="ok">The ok<see cref="bool"/></param>
        /// <param name="code">The code<see cref="int"/></param>
        /// <param name="page">The page<see cref="int"/></param>
        /// <param name="pageSize">The pageSize<see cref="int"/></param>
        /// <param name="message">The message<see cref="string"/></param>
        /// <param name="data">The data<see cref="object"/></param>
        /// <param name="totalPages">The totalPages<see cref="int?"/></param>
        /// <param name="totalPages">The totalPages<see cref="int?"/></param>
        /// <param name="hasNext">The pageCount<see cref="bool?"/></param>
        /// <param name="hasPrevious">The pageCount<see cref="bool?"/></param>
        public ApiResponse(
            bool ok,
            int code,
            int page,
            int pageSize,
            string message,
            T data,
            int? totalPages = 0,
            int? totalCount = 0,
            bool? hasNext = false,
            bool? hasPrevious = false)
        {
            Code = code;
            Ok = ok;
            Page = page;
            PageSize = pageSize;
            TotalPages = totalPages;
            TotalCount = totalCount;
            HasNext = hasNext;
            HasPrevious = hasPrevious;
            Message = message;
            Data = data;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponse"/> class.
        /// </summary>
        public ApiResponse()
        {
        }
    }
}
