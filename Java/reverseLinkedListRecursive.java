/*
Recursive Solution
*/
Node Reverse(Node head) {
    
    if(head==null){
        return head;
    }
    if(head.next == null){
        return head;
    }
    
    Node curr = Reverse(head.next);
    head.next.next = head;
    head.next = null;
    
    return curr;
}