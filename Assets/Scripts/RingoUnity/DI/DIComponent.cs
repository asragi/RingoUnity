using System.Net.Http;
using RingoLib.Authorization.SignUp.Infrastructures.HTTP;
using RingoLib.Authorization.SignUp.Repositories;
using RingoLib.Core.Utils;
using RingoUnity.Utils;
using UnityEngine;

namespace RingoUnity.DI
{
	public class DIComponent: MonoBehaviour
	{
        private static readonly string LocalServerURL = "http://localhost:3000/";
		[SerializeField] DIMode Mode;

        private void Awake()
        {
            var client = new HttpClient();
            var json = new RJson();
            if (Mode == DIMode.Local) {
                IDGenerator = new UUIDGenerator();
                UserAuthRepository = new UserAuthRepository(client, json, LocalServerURL);
	        }
        }

        public IIDGenerator IDGenerator { get; private set; }
        public IUserAuthRepository UserAuthRepository { get; private set; }
    }
}
