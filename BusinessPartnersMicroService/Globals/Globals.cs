using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Globals
{
    //offline
    //public static string auth_endpoint = "http://localhost:14726/";//offline
    //public static string mqtt_server = "localhost";//offline

    //online
    //public static string auth_endpoint = "https://localhost/auth";//online
    public static string auth_endpoint = "https://localhost:44306/";//online
    public static string mqtt_server = "3.130.10.197";//online




    public static string smartpay_end_point = "http://3.130.10.197:17000";
    //live 
    public static string gupshup_end_point = "https://api.gupshup.io/sm/api/v1/msg";
    public static string gupshup_apikey = "3cab8b6156a4454ec5a6cbd6b00d528c";
    public static string gupshup_source = "263773329403";
    public static string src_name = "Speedlinkcargo";

    public static string ecocash_username = "scb";
    public static string ecocash_password = "a!hksrtsb";

    //for images /wwwroot/uploads
    public static string base_path = "https://rubieminnovations.com:9002/SpeedLinkApi";



    /// <summary>
    /// return a mapped object from source class to destination class
    /// </summary>
    public static TDestination AutoMapper<TSource, TDestination>(TSource source_item)
    {
        var auto_mapper_config = new MapperConfiguration(i => i.CreateMap<TSource, TDestination>());
        var mapper = new Mapper(auto_mapper_config);
        var destination_item = mapper.Map<TDestination>(source_item);
        return destination_item;
    }

    /// <summary>
    /// use this method whne destination object already exists
    /// </summary>
    public static TDestination AutoMapper<TSource, TDestination>(TSource source_item, TDestination destination_item)
    {
        var auto_mapper_config = new MapperConfiguration(i => i.CreateMap<TSource, TDestination>());
        var mapper = new Mapper(auto_mapper_config);
        mapper.Map(source_item,destination_item);
        return destination_item;
    }

}
