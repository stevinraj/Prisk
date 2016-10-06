using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.FormFlow;
using Microsoft.Bot.Builder.Luis;
using Newtonsoft.Json;
using Microsoft.Bot.Builder.Luis.Models;
#pragma warning disable 649
namespace Microsoft.Bot.Sample.DiaRBot
{
    [LuisModel("3fefaa87-3940-403c-912d-3816786c7f7b", "8bb97845d56f44839970746424870001")]
    [Serializable]
    class GetDetailsDialog : LuisDialog<GetDetails>
    {
        private readonly BuildFormDelegate<GetDetails> DetailsForm;

        internal GetDetailsDialog(BuildFormDelegate<GetDetails> DetailsForm)
        {
            this.DetailsForm = DetailsForm;
        }

        [LuisIntent("")]
        public async Task None(IDialogContext context, LuisResult result)
        {
            await context.PostAsync("I'm sorry. I didn't understand you.  Could you try 'List' or 'Get Benefits' or something similar.");
            context.Wait(MessageReceived);
        }

        [LuisIntent("List")]
        public async Task ProcessDetailsForm(IDialogContext context, LuisResult result)
        {
            var entities = new List<EntityRecommendation>(result.Entities);
            //            if (!entities.Any((entity) => entity.Type == "sex"))
            //            {
            // Infer gender
            //foreach (var entity in result.Entities)
            //{
            //string gender = null;
            //switch (entity.Type)
            //{
            //            case "Male": gender = "Male"; break;
            //            case "Female": gender = "Female"; break;
            //
            //}
            //if (gender != null)
            //{
            //entities.Add(new EntityRecommendation(type: "Gender") { Entity = gender });
            //break;
            //}
            //}
            //}

            {
                var detailsForm = new FormDialog<GetDetails>(new GetDetails(), this.DetailsForm, FormOptions.PromptInStart);
                context.Call<GetDetails>(detailsForm, DetailsFormComplete);
            }
        }
        

        private async Task DetailsFormComplete(IDialogContext context, IAwaitable<GetDetails> result)
        {
            GetDetails order = null;
            try
            {
                order = await result;
            }
            catch (OperationCanceledException)
            {
                await context.PostAsync("You canceled the form!");
                return;
            }

            if (order != null)
            {

                //if (asex == 1)
                //{
                    // risk = risk + amabo;
                
                //}
                // else
                //{
                //    risk = risk + afabo;
                //    await context.PostAsync("Your current diabetic risk score is: " + risk);
                //}

            }
            else
            {
                await context.PostAsync("Sorry, you are not eligible for any benefits at this point in time.");
            }

            context.Wait(MessageReceived);
        }
    }
}