/*
 * Copyright 2022 Google LLC
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     https://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

// [START livestream_stop_channel]

using Google.Cloud.Video.LiveStream.V1;
using Google.LongRunning;
using System.Threading.Tasks;

public class StopChannelSample
{
    public async Task StopChannelAsync(
         string projectId, string locationId, string channelId)
    {
        // Create the client.
        LivestreamServiceClient client = LivestreamServiceClient.Create();

        StopChannelRequest request = new StopChannelRequest
        {
            ChannelName = ChannelName.FromProjectLocationChannel(projectId, locationId, channelId)
        };

        // Make the request.
        Operation<ChannelOperationResponse, OperationMetadata> response = await client.StopChannelAsync(request);

        // Poll until the returned long-running operation is complete.
        await response.PollUntilCompletedAsync();
    }
}
// [END livestream_stop_channel]