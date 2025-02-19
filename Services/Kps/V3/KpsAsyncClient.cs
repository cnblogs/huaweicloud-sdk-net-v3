using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Kps.V3.Model;

namespace HuaweiCloud.SDK.Kps.V3
{
    public partial class KpsAsyncClient : Client
    {
        public static ClientBuilder<KpsAsyncClient> NewBuilder()
        {
            return new ClientBuilder<KpsAsyncClient>();
        }

        
        /// <summary>
        /// 绑定SSH密钥对
        /// </summary>
        public async Task<AssociateKeypairResponse> AssociateKeypairAsync(AssociateKeypairRequest associateKeypairRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/keypairs/associate",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", associateKeypairRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<AssociateKeypairResponse>(response);
        }
        
        /// <summary>
        /// 创建和导入SSH密钥对
        /// </summary>
        public async Task<CreateKeypairResponse> CreateKeypairAsync(CreateKeypairRequest createKeypairRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/keypairs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createKeypairRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateKeypairResponse>(response);
        }
        
        /// <summary>
        /// 删除所有失败的任务
        /// </summary>
        public async Task<DeleteAllFailedTaskResponse> DeleteAllFailedTaskAsync(DeleteAllFailedTaskRequest deleteAllFailedTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/failed-tasks",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAllFailedTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteAllFailedTaskResponse>(response);
        }
        
        /// <summary>
        /// 删除失败的任务
        /// </summary>
        public async Task<DeleteFailedTaskResponse> DeleteFailedTaskAsync(DeleteFailedTaskRequest deleteFailedTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id" , deleteFailedTaskRequest.TaskId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/failed-tasks/{task_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteFailedTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteFailedTaskResponse>(response);
        }
        
        /// <summary>
        /// 删除SSH密钥对
        /// </summary>
        public async Task<DeleteKeypairResponse> DeleteKeypairAsync(DeleteKeypairRequest deleteKeypairRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("keypair_name" , deleteKeypairRequest.KeypairName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/keypairs/{keypair_name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteKeypairRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteKeypairResponse>(response);
        }
        
        /// <summary>
        /// 解绑SSH密钥对
        /// </summary>
        public async Task<DisassociateKeypairResponse> DisassociateKeypairAsync(DisassociateKeypairRequest disassociateKeypairRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/keypairs/disassociate",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", disassociateKeypairRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<DisassociateKeypairResponse>(response);
        }
        
        /// <summary>
        /// 查询失败的任务信息
        /// </summary>
        public async Task<ListFailedTaskResponse> ListFailedTaskAsync(ListFailedTaskRequest listFailedTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/failed-tasks",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFailedTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListFailedTaskResponse>(response);
        }
        
        /// <summary>
        /// 查询SSH密钥对详细信息
        /// </summary>
        public async Task<ListKeypairDetailResponse> ListKeypairDetailAsync(ListKeypairDetailRequest listKeypairDetailRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("keypair_name" , listKeypairDetailRequest.KeypairName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/keypairs/{keypair_name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listKeypairDetailRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListKeypairDetailResponse>(response);
        }
        
        /// <summary>
        /// 查询任务信息
        /// </summary>
        public async Task<ListKeypairTaskResponse> ListKeypairTaskAsync(ListKeypairTaskRequest listKeypairTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id" , listKeypairTaskRequest.TaskId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/tasks/{task_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listKeypairTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListKeypairTaskResponse>(response);
        }
        
        /// <summary>
        /// 查询SSH密钥对列表
        /// </summary>
        public async Task<ListKeypairsResponse> ListKeypairsAsync(ListKeypairsRequest listKeypairsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/keypairs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listKeypairsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListKeypairsResponse>(response);
        }
        
        /// <summary>
        /// 查询正在处理的任务信息
        /// </summary>
        public async Task<ListRunningTaskResponse> ListRunningTaskAsync(ListRunningTaskRequest listRunningTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/running-tasks",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRunningTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListRunningTaskResponse>(response);
        }
        
        /// <summary>
        /// 更新SSH密钥对描述
        /// </summary>
        public async Task<UpdateKeypairDescriptionResponse> UpdateKeypairDescriptionAsync(UpdateKeypairDescriptionRequest updateKeypairDescriptionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("keypair_name" , updateKeypairDescriptionRequest.KeypairName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/keypairs/{keypair_name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateKeypairDescriptionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateKeypairDescriptionResponse>(response);
        }
        
    }
}