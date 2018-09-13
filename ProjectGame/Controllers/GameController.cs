using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ServiceGame;

namespace ProjectGame.Controllers
{
    public class GameController : ApiController
    {
            public HttpResponseMessage Get()
            {
                using (GameDBEntities1 entiti =new GameDBEntities1())
                {
                    return Request.CreateResponse(HttpStatusCode.OK, entiti.Game.ToList());
                }
            }
            public HttpResponseMessage Get(int id)
            {
               
                using (GameDBEntities1 entities = new GameDBEntities1())
                {
                    Game result = entities.Game.FirstOrDefault(f => f.ID == id);
                    if (result != null)
                        return Request.CreateResponse(HttpStatusCode.OK, result);
                    else
                        return Request.CreateResponse(HttpStatusCode.NotFound, "id: " + id + " not found");
                }
            }
            [HttpGet]
            [Route("api/Game/GetByName/{name}")]
            public HttpResponseMessage GetByName(string name)
            {
                using (GameDBEntities1 entities = new GameDBEntities1())
                {
                   List<Game> result = entities.Game.Where(g => g.Game_Name == name).ToList();
                    if (result != null)
                        return Request.CreateResponse(HttpStatusCode.OK, result);
                    else
                        return Request.CreateResponse(HttpStatusCode.NotFound, "name: " + name + " not found");
                }
            }
        [HttpGet]
        [Route("api/Game/GetByWiner/{win}")]
        public HttpResponseMessage GetByWiner(string win)
        {
            using (GameDBEntities1 entities = new GameDBEntities1())
            {
                List<Game> result = entities.Game.Where(g => g.Who_Win == win).ToList();
                if (result != null)
                    return Request.CreateResponse(HttpStatusCode.OK, result);
                else
                    return Request.CreateResponse(HttpStatusCode.NotFound, "winer: " + win + " not found");
            }
        }
        //   [HttpGet]
        //  [Route("api/game/SearchFilter")]
        //public HttpResponseMessage GetByFilter(string name = "", string player1 = "", string player2 = "", string who_win = "not know")
        //{
        //    using (GameDBEntities1 entities = new GameDBEntities1())
        //    {
        //        List<Game> result = entities.Game.Where(m => m.Game_Name.StartsWith(name) && player1 =="" ? true : m.Player1 == player1 && player2 == "" ? true : m.Player2 == player2 && who_win == "" ? true : m.Who_Win == who_win).ToList();
        //        if (result.Count > 0)
        //            return Request.CreateResponse(HttpStatusCode.OK, result);
        //        //else
        //        //    return Request.CreateResponse(HttpStatusCode.NotFound, String.Format("Name which game  with {0} and  {1} could not be found!", nameGame, player1, player2, who_win));
        //    }

        //}

        public HttpResponseMessage Post([FromBody]Game game)
            {
                using (GameDBEntities1 entities = new GameDBEntities1())
                {
                    entities.Game.Add(game);
                    entities.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.Created, "the new game created!");
                }
            }

            public HttpResponseMessage Put(int id, [FromBody]Game game)
            {
                using (GameDBEntities1 entities = new GameDBEntities1())
                {
                    Game g = entities.Game.FirstOrDefault(x => x.ID == id);
                    if (g != null)
                    {

                        g.Game_Name = game.Game_Name;
                        g.Player1 = game.Player1;
                        g.Player2 = game.Player2;
                        g.Who_Win = game.Who_Win;
                        entities.SaveChanges();
                        return Request.CreateResponse(HttpStatusCode.OK, "Game id: " + id + "update!");
                    }
                    else
                        return Request.CreateResponse(HttpStatusCode.NotFound, "Game id: " + id + "not found");
                }

            }
            public HttpResponseMessage Delete(int id)
            {
                using (GameDBEntities1 entities = new GameDBEntities1())
                {
                    Game delete = entities.Game.FirstOrDefault(x => x.ID == id);
                    if (delete != null)
                    {
                        entities.Game.Remove(delete);
                        entities.SaveChanges();
                        return Request.CreateResponse(HttpStatusCode.OK, "id: " + id + " delete");

                    }
                    else
                        return Request.CreateResponse(HttpStatusCode.NotFound, "id: " + id + " not found");
                }
            }
        }
    }

