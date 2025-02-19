using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Eip.V3.Model;

namespace HuaweiCloud.SDK.Eip.V3
{
    public partial class EipClient : Client
    {
        public static ClientBuilder<EipClient> NewBuilder()
        {
            return new ClientBuilder<EipClient>();
        }

        
        /// <summary>
        /// 查询公共池列表
        /// </summary>
        public ListCommonPoolsResponse ListCommonPools(ListCommonPoolsRequest listCommonPoolsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/publicip-pools/common-pools",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCommonPoolsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListCommonPoolsResponse>(response);
        }
        
        /// <summary>
        /// 查询公共池分组列表
        /// </summary>
        public ListPublicBorderGroupsResponse ListPublicBorderGroups(ListPublicBorderGroupsRequest listPublicBorderGroupsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/public-border-groups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPublicBorderGroupsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListPublicBorderGroupsResponse>(response);
        }
        
        /// <summary>
        /// 查询指定租户下的共享带宽类型列表
        /// </summary>
        public ListShareBandwidthTypesResponse ListShareBandwidthTypes(ListShareBandwidthTypesRequest listShareBandwidthTypesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/share-bandwidth-types",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listShareBandwidthTypesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListShareBandwidthTypesResponse>(response);
        }
        
        /// <summary>
        /// 绑定弹性公网IP
        /// </summary>
        public AssociatePublicipsResponse AssociatePublicips(AssociatePublicipsRequest associatePublicipsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("publicip_id" , associatePublicipsRequest.PublicipId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/publicips/{publicip_id}/associate-instance",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", associatePublicipsRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<AssociatePublicipsResponse>(response);
        }
        
        /// <summary>
        /// 解绑弹性公网IP
        /// </summary>
        public DisassociatePublicipsResponse DisassociatePublicips(DisassociatePublicipsRequest disassociatePublicipsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("publicip_id" , disassociatePublicipsRequest.PublicipId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/publicips/{publicip_id}/disassociate-instance",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", disassociatePublicipsRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<DisassociatePublicipsResponse>(response);
        }
        
        /// <summary>
        /// 查询公网IP池列表
        /// </summary>
        public ListPublicipPoolResponse ListPublicipPool(ListPublicipPoolRequest listPublicipPoolRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/publicip-pools",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPublicipPoolRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListPublicipPoolResponse>(response);
        }
        
        /// <summary>
        /// 全量查询弹性公网IP列表
        /// </summary>
        public ListPublicipsResponse ListPublicips(ListPublicipsRequest listPublicipsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/publicips",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPublicipsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListPublicipsResponse>(response);
        }
        
        /// <summary>
        /// 查询弹性公网IP详情
        /// </summary>
        public ShowPublicipResponse ShowPublicip(ShowPublicipRequest showPublicipRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("publicip_id" , showPublicipRequest.PublicipId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/publicips/{publicip_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPublicipRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowPublicipResponse>(response);
        }
        
        /// <summary>
        /// 查询公网IP池详情
        /// </summary>
        public ShowPublicipPoolResponse ShowPublicipPool(ShowPublicipPoolRequest showPublicipPoolRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("publicip_pool_id" , showPublicipPoolRequest.PublicipPoolId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/eip/publicip-pools/{publicip_pool_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPublicipPoolRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowPublicipPoolResponse>(response);
        }
        
    }
}