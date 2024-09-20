namespace Core.Constants;

public static class Messages
{
    // META
    public const string YouCantDoThat = "Bu işlemi yapamazsınız";
    public const string Success = "İşlem başarıyla tamamlandı";
    public const string NotFound = "Kayıt bulunamadı";
    public const string Error = "Hata alındı";

    // AUTH SERVICE
    public const string RefreshTokenNotValid = "Refresh token geçerli değil";
    public const string EmailAlreadyTaken = "Bu email zaten alınmış";
    public const string UserNameAlreadyTaken = "Bu kullanıcı adı zaten alınmış";
    public const string UserNameOrPasswordWrong = "Kullanıcı adı veya şifre yanlış";
    public const string WrongUserTypes = "Belirtilen yetkiler birlikte alınamaz";

    // SUCCESS
    public const string SuccessfullyCreatedEntity = "Kayıt başarıyla oluşturuldu";
    public const string SuccessfullyUpdatedEntity = "Kayıt başarıyla güncellendi";
    public const string SuccessfullyDeletedEntity = "Kayıt başarıyla silindi";

    //FILE UPLOAD
    public const string InvalidFileFormat = "Geçersiz dosya türü";

    //EVENT
    public const string InvalidDateRange = "Bitiş tarihi, başlangıç tarihinden önce olamaz";
    public const string InvalidUserType = "Bu kullanıcı tipi takvime veri ekleyemez";

    //PROJECT GROUP
    public const string UserAlreadyRegisteredMessage = "Kullanıcı zaten bu projeye kayıtlıdır";

}
