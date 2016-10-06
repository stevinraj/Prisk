using System.Web.Http;
using System.Threading.Tasks;

using Microsoft.Bot.Connector;
using Microsoft.Bot.Builder.FormFlow;
using Microsoft.Bot.Builder.Dialogs;
using System.Web.Http.Description;
using System.Net.Http;
using System.Diagnostics;

namespace Microsoft.Bot.Sample.DiaRBot
{
    [BotAuthentication]
    public class MessagesController : ApiController
    {
       private static IForm<GetDetails> BuildForm()
        {
            var builder = new FormBuilder<GetDetails>();

            return builder
                .Message("Welcome to Pregnancy Risk Assessment Bot!")
                .Field(nameof(GetDetails.sex))
                .Field(nameof(GetDetails.agecat))
                .Field(nameof(GetDetails.nofkids))
                .Field(nameof(GetDetails.abortion))
                .Field(nameof(GetDetails.postparthem))
                .Field(nameof(GetDetails.babysweight))
                .Field(nameof(GetDetails.preghtn))
                .Field(nameof(GetDetails.infertility))
                .Field(nameof(GetDetails.prevcsec))
                .Field(nameof(GetDetails.stillbirth))
                .Field(nameof(GetDetails.difflabor))
                .Field(nameof(GetDetails.bleeding))
                .Field(nameof(GetDetails.anemia))
                .Field(nameof(GetDetails.hypertension))
                .Field(nameof(GetDetails.edema))
                .Field(nameof(GetDetails.albuminuria))
                .Field(nameof(GetDetails.multiplepreg))
                .Field(nameof(GetDetails.breech))
                .Field(nameof(GetDetails.rhimmuniz))
                .Field(nameof(GetDetails.prolongedlabor))
                .Field(nameof(GetDetails.premruptmemb))
                .Field(nameof(GetDetails.polyhydraminos))
                .Field(nameof(GetDetails.smallfetus))
                .Field(nameof(GetDetails.diabetes))
                .Field(nameof(GetDetails.cardiacdis))
                .Field(nameof(GetDetails.prevgynsurg))
                .Field(nameof(GetDetails.crd))
                .Field(nameof(GetDetails.infhep))
                .Field(nameof(GetDetails.pultub))
                .Field(nameof(GetDetails.otherdis))
                .Field(nameof(GetDetails.undnut))
                .Build()
                ;
        }

        internal static IDialog<GetDetails> MakeRoot()
        {
            return Chain.From(() => new GetDetailsDialog(BuildForm));
        }

        /// <summary>
        /// POST: api/Messages
        /// receive a message from a user and send replies
        /// </summary>
        /// <param name="activity"></param>
        [ResponseType(typeof(void))]
        public virtual async Task<HttpResponseMessage> Post([FromBody] Activity activity)
        {
            if (activity != null)
            {
                // one of these will have an interface and process it
                switch (activity.GetActivityType())
                {
                    case ActivityTypes.Message:
                        await Conversation.SendAsync(activity, MakeRoot);
                        break;

                    case ActivityTypes.ConversationUpdate:
                    case ActivityTypes.ContactRelationUpdate:
                    case ActivityTypes.Typing:
                    case ActivityTypes.DeleteUserData:
                    default:
                        Trace.TraceError($"Unknown activity type ignored: {activity.GetActivityType()}");
                        break;
                }
            }
            return new HttpResponseMessage(System.Net.HttpStatusCode.Accepted);
        }
    }
}

