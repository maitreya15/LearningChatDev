//This will be in new file (new Folder too )
namespace FormfieldsTest.Forms
{
    public class SelectConfRoom
    {
        public enum RoomOptions1 { Conf1, Conf2, Conf3 }
        public enum RoomOptions2 { Conf12, Conf22, Conf32 }


        [Serializable]
        public class ConfRoom
        {
            public RoomOptions1? room1;
            public RoomOptions2? room2;

            public static IForm<ConfRoom> BuildForm()
            {
                return new FormBuilder<ConfRoom>()
                    .Message("foorm")
                    .Build();
            }
        };
    }
}

//TO implement : In msgcntrl.cs
internal static IDialog<ConfRoom> MakeRootDialog()
        {
            return Chain.From(() => FormDialog.FromForm(ConfRoom.BuildForm))
                .Do(async (context, order) =>
                {
                    var completed = await order;
                    await context.PostAsync("STRING TO PRINT");
                }
                );
        }