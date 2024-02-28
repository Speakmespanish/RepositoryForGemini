namespace Social.Core.Application.ViewModels.Friendship
{
    public class SaveFriendship_vm
    {
        public int User1Id { get; set; }    //Representa a quien envio la solicitud de amistad

        public int User2Id { get; set; }     //Representa a quien acepto la solicitud de amistad
    }
}
