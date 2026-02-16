public static void MergeSort(int[] arr,int left,int right)
{
    if(left<right)
    {
        MergeSort(arr,left,mid);
        MergeSort(arr,mid+1,right);
        Merge(arr,left,mid,right);
    }
}
private static void Merge (int[] arr, int left, int mid , int right)
{
     int n1= mid-left+1;
     int n2=right-mid;
     int[] L= new int[n1];
     int[] R= new int[n2];

     for(int i=0;i<n1;i++)
        L[i]=arr[left+i];
     for(int j=0;j<n2;j++)
        R[i]=arr[mid+1+i];

    int iIndex=0,jIndex=0;
    int k=left;

    while(iIndex<n1 && jIndex<n2)
    {
        if(L[iIndex]<=R[jIndex])
        {
            arr[k]=L[iIndex];
            iIndex++;
        }
        else
        {
             arr[k]=R[jIndex];
            jIndex++;
        }
        k++;
    }
    while(iIndex<n1)
    {
        arr[k]=L[iIndex];
            iIndex++;
            k++;
    }
     while(jIndex<n2)
    {
        arr[k]=R[jIndex];
            jIndex++;
            k++;
    }
}